using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{

    class Demo
    {
        private string[] val = new string[3];
        public string this[int index]
        {
            get { return val[index]; }
            set
            {
                val[index] = value;
            }
        }

    }
    internal class Indexer
    {
        public static void Main4()
        {
            Demo demo = new Demo();
            demo[0] = "Vikash";
            demo[1] = "Vikash 1";
            demo[2] = "Vikash 2";
            Console.WriteLine(demo[0]);
        }
    }
}
