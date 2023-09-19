using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Animal
    {
        public virtual void show()
        {
            Console.WriteLine("I am base class");
        }
        public string name;
    }
    class Dog : Animal 
    {
        //shodowing
        new int name;
        public  override void show()
        {
            Console.WriteLine("I am derived class");
        }
    }
    internal class OverridingDemo
    {
        static void Main3(string[] args)
        {
            Dog dogdemo = new Dog();
            dogdemo.show();
            Console.WriteLine("=================");
            Animal animal = new Dog();
            animal.show();
            Console.ReadKey();
        }
    }
}
