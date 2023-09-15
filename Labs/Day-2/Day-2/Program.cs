namespace Day_2
{
    class Person
    {
        public Person()
        {
            Name = "Vikash Verma";
        }
        protected string Name { get; set; }
    }
    class Employee:Person
    {
        //field
        private int id;
        //properties
        public int Id { get; set; }

        public void Show()
        {
            Console.WriteLine("Employee Id is "+id);
            Console.WriteLine("Employee Name is "+Name);
        }
        public Employee() {
           // Console.WriteLine("Hi I am a constructor");
           Id= 1;
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Employee emp = new Employee();
            emp.Show();
        }
    }
}