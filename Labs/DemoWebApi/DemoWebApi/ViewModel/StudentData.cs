namespace DemoWebApi.ViewModel
{
    public class StudentData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }

        public List<StudentBooks> studentBooks { get; set; }    

    }
    public class StudentBooks
    {
        public int Id { get; set; }
        public string BookName { get; set; }
    }
}
