using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Functiondemo
    {
        // <return type> nameoffunction (<parameters>)

        public static void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static void swap(ref int  a,ref int b)
        {
            int c;
            c = b;
            b = a;
            a = c;
            Console.WriteLine(" a="+a+" b="+b);
        }
        public static void OutDemo(out int a)
        {
            a = 6;
            //Console.WriteLine(a);
        }
        public static void RefDemo(ref int a)
        {
            Console.WriteLine(a);
        }

        public static void InDemo(in int a)
        {
            Console.WriteLine(a);
        }
        //in ,ref,out
        static void Main2(string[] args)
        {
            int a = 1, b = 2;
            //Console.WriteLine("value of a=" + a + "b=" + b+"before calling SWAP");
            //swap(ref a, ref b);
            //Console.WriteLine("value of a=" + a + "b=" + b+ "after calling SWAP"); 
            int outResult;
            int refResult=1;
            OutDemo(out outResult);
            RefDemo(ref refResult);
            Console.WriteLine(outResult);
        }
    }
}
