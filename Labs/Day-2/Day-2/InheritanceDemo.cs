using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{

    class A
    {
        public A() {
            Console.WriteLine("I am in A");
        }
    }
    class B:A
    {
       public B() {
            Console.WriteLine("I am in B");
        }
    }
    class C:B
    {
       public C() {
            Console.WriteLine("I am in C");
        }
    }
    internal class InheritanceDemo
    {
        static void Main2(string[] args)
        {
            C c = new C();
            Console.ReadLine();
        }
    }
}
