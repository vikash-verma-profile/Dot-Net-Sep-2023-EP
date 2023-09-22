using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Stack<T>
    {
        int currentvalue = -1;

        T[] items;
        public Stack(int size) { 
            items=new T[size];
        }

        public bool Empty => currentvalue == -1;
        public bool Full => currentvalue == items.Length-1;

        public bool push(T item)
        {
            if (!Full)
            {
                items[++currentvalue] = item;
                return true;
            }
            return false;
        }
       public T? pop()=>!Empty? items[currentvalue--] : default(T);


    }
    internal class Class1
    {
        public static void Main()
        {
            Stack<int> s = new Stack<int>(1);
            s.push(1);
            Console.WriteLine(s.pop());
            Console.ReadKey();
        }
    }
}
