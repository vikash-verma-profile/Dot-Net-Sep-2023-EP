using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class arrademo
    {
        static void Main4(string[] args)
        {
            //int[] sample = { 1, 2, 3, 4, 5, };
            //foreach (var item in sample)
            //{
            //    Console.WriteLine(item);
            //}

            //string name = "Vikash Verma";
            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);
            //}

            //int[,] demos = { { 1,2},{ 3,4} };

            //for (int row = 0; row < 2; row++)
            //{

            //    for (int col = 0; col < 2; col++)
            //    {
            //        Console.Write("\t"+demos[row, col]);
            //    }
            //    Console.WriteLine();
            //}
            int[][] jaggedArrays = new int[2][];

            jaggedArrays[0] = new int[] {1,2,3};
            jaggedArrays[1] = new int[] { 5, 7, 8, 0 };
            foreach (var item in jaggedArrays)
            {
                foreach (var item1 in item)
                {
                    Console.Write(item1);
                  
                }
                Console.WriteLine();
            }
        }
    }
}
