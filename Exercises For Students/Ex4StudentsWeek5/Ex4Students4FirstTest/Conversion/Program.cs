using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to convert ");
            Conversion();
        }
        static void Conversion()
        {
            int n, i;

            int[] a = new int[10];

            n = int.Parse(Console.ReadLine());

            for (i = 0; 0 < n; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
