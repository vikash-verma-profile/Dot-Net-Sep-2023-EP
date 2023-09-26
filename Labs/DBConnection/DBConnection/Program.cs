using DBConnection.Models;

namespace DBConnection
{
    internal class Program
    {
        public static void GetValueFromDB(BookDbContext db)
        {
            var books = db.TblBooks;
            foreach (var item in books)
            {
                Console.WriteLine(item.BookName);
            }
        }

        public static void AddDatatoDB(BookDbContext db)
        {
            Console.WriteLine("Please enter some book name: ");
            TblBook book = new TblBook();
            book.BookName = Console.ReadLine();
            db.Add(book);
            db.SaveChanges();

        }
        static void Main(string[] args)
        {

           
            BookDbContext db = new BookDbContext();
            AddDatatoDB(db);
            GetValueFromDB(db);




        }
    }
}