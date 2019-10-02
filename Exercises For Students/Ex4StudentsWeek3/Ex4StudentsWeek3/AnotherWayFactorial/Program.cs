using System;

namespace AnotherWayFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            Console.Write("n! = "+ n);
            while (true)
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;

                Console.Write(" * " + n);
            }
            Console.WriteLine(" = "+ factorial);
        }
    }
}
