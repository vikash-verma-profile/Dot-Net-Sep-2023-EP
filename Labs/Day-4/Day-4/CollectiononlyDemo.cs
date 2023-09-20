using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class CollectiononlyDemo
    {
        public static void Main5()
        {
            ArrayList arrayList= new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Vikash");
            arrayList.Add(3);
            arrayList.Add(4);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
