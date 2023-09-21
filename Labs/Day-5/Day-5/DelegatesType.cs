using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class DelegatesType
    {
        public static int sum(int a,int b)
        {
            return (a + b);
        }
        public static void sumA(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static bool sumP(int a)
        {
            return (a > 5) ?true:false;
        }
        public static void Main5()
        {
            Func<int, int, int> func = sum;
            Console.WriteLine(func(1,2));

            Action<int, int> ac = sumA;
            ac(1, 3);

            Predicate<int> predicate= sumP;

            if (sumP(1))
            {
                Console.WriteLine("a is greater than 5");
            }
            else
            {
                Console.WriteLine("a is less than 5");
            }

            Console.ReadKey();

        }
    }
}
