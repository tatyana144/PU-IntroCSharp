using System;
using System.Numerics;
using System.Text;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            while (true)
            {
                if(n <= 1)
                {
                    break;
                }

                factorial *= n;
                n--;
            }

            Console.WriteLine("n! = " + factorial);
        }
    }
}
