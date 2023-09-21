namespace Day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\om\\Desktop\\Dot-Net-Core\\Labs\\Day-5\\Day-5\\files\\test.txt");
            sw.WriteLine("Vikash");
            sw.Flush();
            sw.Close();
            Console.WriteLine("Hello, World!");
        }
    }
}