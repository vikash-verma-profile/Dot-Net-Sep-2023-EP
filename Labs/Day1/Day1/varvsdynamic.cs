using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class varvsdynamic
    {
        static void Main(string[] args)
        {
            dynamic i = "1";
            Console.WriteLine(i.GetType());
            i = 1;
            Console.WriteLine(i.GetType());
        }
    }
}
