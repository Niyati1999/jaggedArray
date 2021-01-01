using System;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 100, 200, 300 };
            jaggedArray[2] = new int[] { 500, 600,700,800,900 };
            jaggedArray[3] = new int[] { 1000, 2000 };
            int l = jaggedArray.Length;
            Console.WriteLine(l);
            Console.WriteLine(jaggedArray[2].Length);
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] +"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
