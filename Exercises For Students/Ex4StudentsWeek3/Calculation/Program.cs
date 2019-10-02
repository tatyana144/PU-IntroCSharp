using System;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter  m = ");
            int m = int.Parse(Console.ReadLine());
            decimal result = 1;
            for (int i = 0; i< m; i++)
            {
                result *= n;
            }
            Console.WriteLine("n^m = " + result);
        }
    }
}
