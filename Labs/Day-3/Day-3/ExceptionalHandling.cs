using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class ExceptionalHandling
    {
        public static void Main()
        {
            try
            {
                int a = 1;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occured");
            }
            Console.Read();
           
        }
    }
}
