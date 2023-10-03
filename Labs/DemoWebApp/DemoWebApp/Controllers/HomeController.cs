using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DemoWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           // HttpClient client = new HttpClient();
           IEnumerable<Books> booklist=new List<Books>();
            using (HttpClient client = new HttpClient())
            {
                var data=client.GetAsync("https://localhost:7032/api/Home").Result.Content.
                    ReadAsStringAsync().Result;
                booklist=JsonConvert.DeserializeObject< IEnumerable<Books>>(data);
            }
           return View(booklist);
        }
    }
}
