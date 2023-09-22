namespace Day_6
{

    class Test
    {
        public void Print()
        {
            Console.WriteLine("Print method");
        }
    }
    static class TestExtension
    {
        static public void PrintNew(this Test test)
        {
            Console.WriteLine("Print new defination");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test=new Test();
            test.Print();
            test.PrintNew();
        }
    }
}