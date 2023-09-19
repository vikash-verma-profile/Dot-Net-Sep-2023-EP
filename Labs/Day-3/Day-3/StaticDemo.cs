using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    static class StaticDemoClass
    {
        public static int a;
        //public int c;
    }
    class StaticDemoClass2
    {
        static StaticDemoClass2()
        {
            Console.WriteLine("Hi i am static constructor");
        }
       public StaticDemoClass2()
        {
            Console.WriteLine("Hi i am default constructor");
        }
       public StaticDemoClass2(int a)
        {
            Console.WriteLine("Hi i am parameteized constructor");

        }
        public static int a;
        public int c;
    }

    class D
    {
        private D()
        {

        }
        public static D getInstance()
        {
            return new D();
        }
    }
    internal class StaticDemo
    {
        public static void Main()
        {
            StaticDemoClass.a=1;
            StaticDemoClass2 b = new StaticDemoClass2();
            // StaticDemoClass a = new StaticDemoClass();
            //a.c=2;
            D.getInstance();
        }
    }
}
