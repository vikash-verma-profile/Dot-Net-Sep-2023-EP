using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static System.Reflection.Metadata.BlobBuilder;

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

                if (data != null)
                {
                    return RedirectToAction("BookList", "Book");
                }
                else
                {
                    return View();
                }

            }
            
        }
    }
}
