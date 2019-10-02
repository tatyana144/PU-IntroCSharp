using System;

namespace ShowNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n = ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("The numbers are : ");
            for (int i = 0; i <= end; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
