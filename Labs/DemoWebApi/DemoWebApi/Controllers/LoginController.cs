using DemoWebApi.Models;
using DemoWebApi.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        BookDbContext db=new BookDbContext();
        IConfiguration config;

        public LoginController(IConfiguration configuration)
        {
            config=configuration;   
        }
        [HttpPost]
        public IActionResult login(LoginViewModel login)
        {
            IActionResult respose = Unauthorized();
            var user = ValidateUser(login);
            if(user!=null)
            {
                var tokenString=GenerateToken(user);
                if(tokenString.IsNullOrEmpty())
                {
                    respose = Ok(new {Status=200,Message="Some error occured"});
                }
                respose = Ok(new { Status = 200, Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
            return respose;
        }
        private LoginViewModel ValidateUser(LoginViewModel login)
        {
            if(db.TblLogins.Any(x=>x.UserName==login.UserName && x.Password==login.Password))
            {
                return login;
            }
            else
            {
                return null;
            }
        }
        private string GenerateToken(LoginViewModel login)
        {
            try
            {
                var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:Key"]));
                var crdentials = new SigningCredentials(Key,SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    config["JWT:Issuer"],
                     config["JWT:Audience"],
                     null,
                     null,
                     DateTime.Now.AddMinutes(120),
                     crdentials
                    );
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
