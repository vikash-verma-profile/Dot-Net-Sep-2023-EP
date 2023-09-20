using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Collectionsdemo
    {
        public static void Main()
        {
            Dictionary<int,string> dict=new Dictionary<int,string>();

            dict.Add(1,"Vikash");
            dict.Add(2, "Vikash 1");
            dict.Add(3, "Vikash 2");
            dict.Add(4, "Vikash 3");
            dict.Add(5, "Vikash 4");
            dict.Remove(4);

            foreach (var item in dict)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("====================LIST==================");
            List<string> ls = new List<string>();
            ls.Add("Vikash");
            ls.Add("Vikash 1");
            ls.Add("Vikash 2");
            ls.Add("Vikash 3");
            ls.Add("Vikash 4");
            ls.RemoveAt(1);

            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
        }
    }
}
