using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Anonymous
    {
        // <access modifier> delegate <return> method(Parameters)

        //singnature to a delagte
        public delegate void addNumber(int a,int b);

        public void Sum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Main3()
        {
            
            //anonymous
            //var employee = new { studentID = 101, name = "Vikash" };
            //Console.WriteLine(employee.studentID);

            Anonymous cl= new Anonymous();
            //link delegate and method
            addNumber obj = new addNumber(cl.Sum);

            //invoking the delegate to perform the operation
            obj(1, 2);

          //  Console.WriteLine(obj.ToString());

         

          
        }
    }
}
