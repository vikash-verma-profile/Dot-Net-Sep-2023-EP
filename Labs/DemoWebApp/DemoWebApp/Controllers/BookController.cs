using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DemoWebApp.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddBook(Books books)
        {
            using (HttpClient client = new HttpClient())
            {
               var request= new StringContent(JsonConvert.SerializeObject(books),System.Text.Encoding.UTF8,"application/json");
               var data = client.PostAsync("https://localhost:7032/api/Home",request).Result.Content.
                    ReadAsStringAsync().Result;
               
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
