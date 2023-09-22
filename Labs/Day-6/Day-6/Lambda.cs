using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{

    partial class Part1
    {
        public void Print1()
        {
            Console.WriteLine("Hi i am from part1");
        }
    }
    partial class Part1
    {
        public void Print2() { Console.WriteLine("Hi I am from part2"); }
    }
    internal class Lambda
    {
        public static void Main2()
        {
            //List<int> Numbers=new List<int>() { 1,2,3,4,5,6};

            //List<int> evenNumbers = Numbers.FindAll(x => (x % 2) == 0);

            //foreach (var item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            Part1 p = new Part1();
            p.Print2();
            p.Print1();

        }
    }
}
