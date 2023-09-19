namespace Day_3
{
    //method overloading

    class OverloadingDemo
    {
        public  void sum(int a,int b)
        {
            Console.WriteLine(a + b);   
        }
        public void sum(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }
        public void sum()
        {
            Console.WriteLine("I am empty");
        }
        public void sum(string a,string b)
        {
            Console.WriteLine(a+b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           OverloadingDemo d=new OverloadingDemo();
            d.sum(1,2);
            d.sum(1, 2,3);
            d.sum("Rahul","Sharma");
        }
    }
}