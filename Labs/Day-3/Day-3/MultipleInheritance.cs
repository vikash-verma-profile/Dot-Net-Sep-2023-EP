using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    interface IA
    {
        public void show();
    }
    interface IB
    {
        public void print();
        public void show();
    }
    class c : IA, IB
    {
        void IA.show()
        {
            Console.WriteLine("I am in show of IA");
        }
        public void print() {
            Console.WriteLine("I am in print of IB");
        }
        void IB.show()
        {
            Console.WriteLine("I am in show of IB");
        }
    }
    internal class MultipleInheritance
    {
        static void Main4(string[] args)
        {
            c objC=new c();
            //objC.show();
            //objC.print();
            IA a =new c();
            a.show();
            IB b = new c();
            b.show();

        }
    }
}
