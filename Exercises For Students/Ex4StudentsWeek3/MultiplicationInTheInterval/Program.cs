using System;

namespace MultiplicationInTheInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            int num = n;
            long product = 1;
            Console.Write(n );
            do
            {
                product *= num;
                num++;
                Console.Write(" * " + num);
            }
            while (num < m);
            Console.WriteLine(" = " + product);
            Console.WriteLine("[n * (n+1) * (n+2)..m] = " + product);

        }
    }
}
