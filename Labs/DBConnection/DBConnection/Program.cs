using DBConnection.Models;

namespace DBConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookDbContext db = new BookDbContext();
            var books = db.TblBooks;
            foreach (var item in books)
            {
                Console.WriteLine(item.BookName);
            }
        }
    }
}