using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    enum Status
    {
        Active=1,
        Deactive=2,
        Hold=3
    }
    internal class EnumDemo
    {
        public static void Main2()
        {
            Console.WriteLine((int)Status.Active);

            int input = 1;
            switch ((Status)input)
            {
                case Status.Active:
                    Console.WriteLine(Status.Active);
                    break;
                default:
                    break;
            }


        }
    }
}
