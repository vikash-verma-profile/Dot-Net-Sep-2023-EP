using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    // sum 2 objects

    // <access-specifier> <classname> operator <operator-name> (parameters)

    class sum
    {
        int Number;

        public sum(int Number) {
            this.Number = Number;
        }

        //overloading + operator
        public static sum operator +(sum s1,sum s2)
        {
            sum s3= new sum(0);
            s3.Number = s1.Number + s2.Number;
            return s3;
        }

        public void print()
        {
            Console.WriteLine("Number value is : " + Number);
        }
    }
    internal class OperatorDemo
    {
        static void Main(string[] args)
        {
            sum s1= new sum(1);
            sum s2 = new sum(1);
            sum s3= new sum(0);
            s3 = s2 + s1;
            s3.print();
            Console.ReadLine();

        }
    }
}
