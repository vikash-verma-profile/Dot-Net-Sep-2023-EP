using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    interface IEmployee
    {
        public void show();
    }
    class EmployeeDemo : IEmployee
    {
        public EmployeeDemo(string _employeeName)
        {
            EmployeeName = _employeeName;
        }
        string EmployeeName;
        public void show()
        {
            Console.WriteLine("EmployeeName :" + EmployeeName);
        }
    }
    internal class InterfaceDemo
    {
        static void Main3(string[] args)
        {
            EmployeeDemo d = new EmployeeDemo("Vikash Verma");
            d.show();
        }
    }
}
