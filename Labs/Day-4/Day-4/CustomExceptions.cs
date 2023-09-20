using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public class CustomException:Exception
    {
       public CustomException()
        {

        }
        public CustomException(string message):base(message)
        {


        }

    }
        
    internal class CustomExceptions
    {
        public static void Main3()
        {
            try
            {
                int a = 1;
                int b = 0;
                //int c = a / b;

                if (b == 0)
                {
                    throw new CustomException("Vikash Verma");
                }
                //Console.WriteLine(c);
            }
            catch (CustomException e)
            {
                Console.WriteLine("Hello ! "+e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          Console.ReadKey();
        }
    }
}
