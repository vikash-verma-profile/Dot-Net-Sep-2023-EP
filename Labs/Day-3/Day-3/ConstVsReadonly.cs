using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public class DemoReadOnly
    {
        public readonly int ab = 1;
        public DemoReadOnly(int a)
        {
            ab = a;
        }
        public void Print()
        {
            Console.WriteLine("Value is" + ab);
        }
    }
    internal class ConstVsReadonly
    {
        public static void Main(string[] args)
        {
            const int a= 1;
            //a = 2;
            DemoReadOnly d = new DemoReadOnly(2);
            //d.ab = 1;

            d.Print();

        }
    }
}
