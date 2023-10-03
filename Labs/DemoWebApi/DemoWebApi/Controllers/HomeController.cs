using DemoWebApi.Models;
using DemoWebApi.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
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

        [HttpGet]
        [Route("/get-student-data")]
        public  IEnumerable<StudentData> GetStudentData()
        {
            //var data = db.TblStudents.
            //    Join(db.TblCourses, 
            //    s => s.CourseId, c => c.Id, (s, c) => new { s,c}).
            //    Join(db.TblCourseBookMappings,
            //    course=> course.c.Id,cb=>cb.CourseId,(course,cb)=>new {course,cb}).
            //    Join(db.TblBooks,coursebook=> coursebook.cb.BookId, 
            //    b => b.Id, (coursebook, b) => 
            //    new { Id= coursebook.course.s.Id,Name= coursebook.course.s.StudentName,
            //    CourseName= coursebook.course.c.CourseName

            //    }).ToList();


            var data = db.TblStudents.
               Join(db.TblCourses,
               s => s.CourseId, c => c.Id, (s, c) => 
               new { Id = s.Id, Name = s.StudentName , CourseName = c.CourseName,CourseId=c.Id });

            var books = data.Join(db.TblCourseBookMappings, d => d.CourseId, cb => cb.CourseId
            , (d, cb) => new { d, cb }).Join(db.TblBooks, cbm => cbm.cb.BookId, b => b.Id,

            (cbm,b)=>new {BookId=b.Id,BookName=b.BookName,StudentId=cbm.d.Id });

            List<StudentData> studentdatalist = new List<StudentData>();

            foreach (var item in data)
            {
                StudentData student = new StudentData();
                student.Id = item.Id;
                student.CourseName = item.CourseName;
                student.Name = item.Name;
                List<StudentBooks> studentbooks = new List<StudentBooks>();
                var bookdata = books.Where(x => x.StudentId == item.Id);
                foreach (var book in bookdata)
                {
                    StudentBooks s = new StudentBooks();
                    s.Id = book.BookId;
                    s.BookName = book.BookName;
                    studentbooks.Add(s);

                }
                student.studentBooks=studentbooks;
                studentdatalist.Add(student);
            }

            return studentdatalist;
        }

        [HttpGet]
        [Route("/test")]
        public IList<TblBook> LinqPractice()
        {
            //Take function in Linq
            var data = db.TblBooks.Take(1).ToList();
            //Skip function in Linq
            var temp = db.TblBooks.Skip(2).ToList();
            IQueryable query = db.TblBooks.Skip(1);

            //Orderby function in Linq

            var orderbyvaluedesc = db.TblBooks.OrderByDescending(x => x.Id).ThenBy(x=>x.BookName);
            var orderbyvalueasc = db.TblBooks.OrderBy(x => x.Id);

            List<int> numbers = new List<int> { 1 };
            List<int> emptynumbers = new List<int>();
            var single = numbers.Single();
            var singleandDefault = emptynumbers.SingleOrDefault();


            //select
            var selectedata = db.TblBooks.Select(x => x.Id);
            var democollection = new List<int>() { 1, 2, 3, 4, 4, 4, 6 };
            var democollection2 = new List<int>() { 1, 2, 3, 4, 4, 4, 6 };

            var inetrsect = democollection.Intersect(democollection2);
            var except = democollection.Except(democollection2);

            var distictcollection = democollection.Distinct().ToList();

            var groupbycollection = democollection.GroupBy(X=>X);

            var sum = democollection.Sum(x => { if (x % 2 == 0) { return x; } else { return 0; } });

            //var sql=(System.Data.)query.ToString();
            return data;
        }
        [HttpPost]
        [Route("Validate")]
        public IActionResult SomeApi(SampleRequest sample)
        {
            if(ModelState.IsValid)
            {
                return Ok("Please provide some value.");

            }
            else
            {
                return Ok();
            }

            
        }
    }
}
