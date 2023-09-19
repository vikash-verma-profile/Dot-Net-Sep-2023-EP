using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public class Sample
    {
        private protected int a;
    }
    public class Derived : Sample
    {
        public void show()
        {
            Console.WriteLine(a);
        }
    }
    internal class AccessSpecifier
    {
        public static void Main6()
        {

            Day_3.Demo2.Class1 c1= new Day_3.Demo2.Class1();
            Day_3.Demo1.Class1 c2 = new Day_3.Demo1.Class1();
            c1.show();
            c2.show();
            System.Console.WriteLine();
        }
    }
}
