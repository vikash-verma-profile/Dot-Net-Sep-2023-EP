namespace CodeFirst
{
    internal class Program
    {
        public static void GetValueFromDB(CourseDBContext db)
        {
            var books = db.Course;
            foreach (var item in books)
            {
                Console.WriteLine(item.Id + "|" + item.CourseName);
            }
        }

        public static void AddDatatoDB(CourseDBContext db)
        {
            Console.WriteLine("Please enter some Course name: ");
            Course book = new Course();
            book.CourseName = Console.ReadLine();
            db.Add(book);
            db.SaveChanges();

        }

        public static void UpdateDataInDB(CourseDBContext db)
        {
            Console.WriteLine("enter any Course id which you want to update");
            GetValueFromDB(db);
            int ID = Convert.ToInt32(Console.ReadLine());
            var Course = db.Course.Where(x => x.Id == ID).FirstOrDefault();
            Console.WriteLine("enter book name which you want to update: ");
            string CourseName = Console.ReadLine();
            Course.CourseName = CourseName;
            db.Course.Update(Course);
            db.SaveChanges();
        }
        public static void DeleteDataInDB(CourseDBContext db)
        {
            Console.WriteLine("enter any book id which you want to delete");
            GetValueFromDB(db);
            int ID = Convert.ToInt32(Console.ReadLine());
            var Course = db.Course.Where(x => x.Id == ID).FirstOrDefault();
            db.Course.Remove(Course);
            db.SaveChanges();
        }
        static void Main(string[] args)
        {
            CourseDBContext db = new CourseDBContext();
            AddDatatoDB(db);
            GetValueFromDB(db);
        }
    }
}