using System;

namespace TheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            int sum = 1;
            Console.Write("The sum 1");

            while(num < n)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);
            }
            Console.WriteLine(" = " + sum);
        }
    }
}
