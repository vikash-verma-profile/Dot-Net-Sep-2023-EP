using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    //abstract /sealed
    //object creation is not allowed
    //sealed extension is not allowed
    abstract class Animal
    {
        protected string name;

       // public Animal() { }
        public Animal(string _name) { 
            name=_name;
        }
        
    }
    sealed class Mammel:Animal
    {
        int age;
        public  Mammel(int _age,string _name):base(_name)
        {
            age = _age;
        }

        public void PrintName()
        {
            Console.WriteLine("Name is : " + name + " Age is :" + age);
        }
    }
    class Dog
    { 
        
    }
    internal class AbstractDemo
    {
        static void Main(string[] args)
        {
            Mammel a = new Mammel(12,"Test");
            a.PrintName();
        }
    }
}
