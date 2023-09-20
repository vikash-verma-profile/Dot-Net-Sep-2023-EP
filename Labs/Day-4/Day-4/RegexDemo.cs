using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_4
{
    internal class RegexDemo
    {
        public static void Main()
        {
            string pattern ="^[0-9]{3}$";
            Regex rg = new Regex(pattern);
            if(rg.IsMatch("123"))
            {
                Console.WriteLine("Its matched");
            }
            else
            {
                Console.WriteLine("Not matched");
            }
        }
    }
}
