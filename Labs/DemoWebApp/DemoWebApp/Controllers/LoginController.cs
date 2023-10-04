using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Session;
     
namespace DemoWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginUser(LoginViewModel loginViewModel)
        {
            using (HttpClient client = new HttpClient())
            {
                var request = new StringContent(JsonConvert.SerializeObject(loginViewModel), System.Text.Encoding.UTF8, "application/json");
                var data = client.PostAsync("https://localhost:7032/api/Login", request).Result.Content.
                     ReadAsStringAsync().Result;
                var loginData = JsonConvert.DeserializeObject<ResponseData>(data);
                if (loginData != null)
                {
                    HttpContext.Session.SetString("token",loginData.Token);
                    HttpContext.Session.SetString("username", loginData.Token);
                    return RedirectToAction("BookList", "Book");
                }
                else
                {
                    return View();
                }

            }
            
        }
        public JsonResult CheckLogin()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                return Json(new {username=""});
            }
            else
            {
                return Json(new { username = HttpContext.Session.GetString("username") });
            }
        }
    }
}
