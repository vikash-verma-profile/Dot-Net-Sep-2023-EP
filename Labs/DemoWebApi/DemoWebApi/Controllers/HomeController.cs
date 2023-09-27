using DemoWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        BookDbContext db=new BookDbContext();

        [HttpGet]
        public IEnumerable<TblBook> GetBooks()
        {
            return db.TblBooks;
        }
        [HttpPost]
        public IActionResult PostBooks(TblBook book)
        {
            db.TblBooks.Add(book);
            db.SaveChanges();
            return Ok("Record is being added successfully");
        }

        [HttpPut]
        public IActionResult PutBooks(TblBook book)
        {
            db.TblBooks.Update(book);
            db.SaveChanges();
            return Ok("Record is being successfully successfully");
        }

        [HttpDelete]
        public IActionResult DeleteBooks(int id)
        {
            var book = db.TblBooks.Where(x => x.Id == id).FirstOrDefault();
            db.TblBooks.Remove(book);
            db.SaveChanges();
            return Ok("Record is being deleted successfully");
        }
    }
}
