using System;

namespace TriangleFromNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n =");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n ; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
