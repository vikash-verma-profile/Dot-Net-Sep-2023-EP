namespace Day_4
{

    //class Sample
    //{
    //    public int MyProperty { get; set; }
    //    public Sample()
    //    {

    //    }
    //}
    struct Employee
    {
        public int EmployeeId;
        string EmployeeName;

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Please enter Employee ID:");
            EmployeeId=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter Employee Name:");
            EmployeeName = Console.ReadLine();
        }
        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee ID:"+EmployeeId);
            Console.WriteLine("Employee Name:"+EmployeeName);
        }
    };
   
    internal class Program
    {
        static void Main1(string[] args)
        {
            Employee emp=new Employee();
            emp.GetEmployeeDetails();
            emp.PrintEmployeeDetails();
        }
    }
}