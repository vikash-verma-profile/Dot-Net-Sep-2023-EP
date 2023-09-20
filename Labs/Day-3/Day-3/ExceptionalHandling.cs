using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class AB
    {
        AB() { }
        ~AB()
        {

        }
    }
    internal class ExceptionalHandling
    {
        public static void Main()
        {
            try
            {
                int a = 1;
                int b = 0;
                // int c = a / b;
               // int[] ar = new int[3];
               // Console.WriteLine(ar[4]);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException occured");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException occured");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occured");
            }
            finally
            {
                Console.WriteLine("I am in finally block");
            }
            Console.Read();
           
        }
    }
}
