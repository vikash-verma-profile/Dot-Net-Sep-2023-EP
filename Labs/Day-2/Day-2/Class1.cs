using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    //is operator vs as operator
    public class Class2
    {

    }
    internal class Class1
    {
        public static void print(int a,int b=1)
        {
            Console.WriteLine("a=" + a + " b=" + b);
        }
        public static void printNamed(int a, int b,int c)
        {
            Console.WriteLine("a=" + a + " b=" + b+" c="+c);
        }
        static void Main(string[] args)
        {
            //int sample;
            //bool result  = int.TryParse("1asd", out sample);
            //Console.WriteLine(result);
            //Console.WriteLine(sample);  

            //string s = "vikash";
            //int a = 1;
            //string s1 = "rohit";
            //if(a is string)
            //{
            //    Console.WriteLine(a);  
            //}
            //else
            //{
            //    Console.WriteLine("its is not an string value");
            //}

            Object[] objects = new object[3];
            objects[0] = 1;
            objects[1] = "Vikash";
            objects[2] = new Class2();

            string x = "1";
            x = "2";
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.Append(x);
            stringBuilder.Append("Rohit");
            //for (int i = 0; i < objects.Length; i++)
            //{
            //    if (objects[i] is string)
            //    {
            //        Console.WriteLine(objects[i]);
            //    }
            //    else
            //    {
            //        var s = objects[i] as Class2;
            //        Console.WriteLine(s);
            //    }
            //} 
            //Console.WriteLine(stringBuilder);

            //print(1);

            //printNamed(b:1,a :2);

            printNamed(1,2,4);
        }
    }
}
