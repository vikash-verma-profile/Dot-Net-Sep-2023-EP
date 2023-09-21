using System.Globalization;

namespace Day_5
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            string FilePath = "C:\\Users\\om\\Desktop\\Dot-Net-Core\\Labs\\Day-5\\Day-5\\files\\test.txt";
            StreamWriter sw = new StreamWriter(FilePath);
            Console.WriteLine("Please enter some value");
            string valueToWriteInFile=Console.ReadLine();
            sw.WriteLine(valueToWriteInFile);
            sw.Flush();
            sw.Close();

            StreamReader sr = new StreamReader(FilePath);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
           string output= sr.ReadLine();
            Console.WriteLine("Value from file is "+ output);
            //while()
            //{

            //}
            Console.WriteLine("Hello, World!");
        }
    }
}