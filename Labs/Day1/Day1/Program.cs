namespace Day1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            // <data-type>  <Variable-name> ;
            // firstName
            //FirstName
            int Number1 = 1;
            int Number2 = 2;
            //Console.WriteLine("Please entrer some value");
            //int Number3=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Value entered by user is " + Number3);

            if (Number1 > Number2)
            {
                Console.WriteLine(Number1+" is greater than " + Number2);
            }
            else
            {
                Console.WriteLine(Number2 + " is greater than " + Number1);
            }
            Console.WriteLine("===================================");
            string output = (Number1 > Number2) ?(Number1 + " is greater than " + Number2) :(Number2 + " is greater than " + Number1);
            Console.WriteLine(output);
           
            //if()
            //else if{ }
            //        else { }
        }
    }
}