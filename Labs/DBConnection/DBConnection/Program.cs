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
                Console.WriteLine(item.Id + "|"+item.BookName);
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

        public static void UpdateDataInDB(BookDbContext db)
        {
            Console.WriteLine("enter any book id which you want to update");
            GetValueFromDB(db);
            int ID = Convert.ToInt32(Console.ReadLine());
            var book = db.TblBooks.Where(x => x.Id == ID).FirstOrDefault();
            Console.WriteLine("enter book name which you want to update: ");
            string bookName = Console.ReadLine();
            book.BookName = bookName;
            db.TblBooks.Update(book);
            db.SaveChanges();
        }
        public static void DeleteDataInDB(BookDbContext db)
        {
            Console.WriteLine("enter any book id which you want to delete");
            GetValueFromDB(db);
            int ID = Convert.ToInt32(Console.ReadLine());
            var book = db.TblBooks.Where(x => x.Id == ID).FirstOrDefault();
            db.TblBooks.Remove(book);
            db.SaveChanges();
        }
        static void Main(string[] args)
        {

           
            BookDbContext db = new BookDbContext();
            //AddDatatoDB(db);
            DeleteDataInDB(db);
          
            GetValueFromDB(db);




        }
    }
}