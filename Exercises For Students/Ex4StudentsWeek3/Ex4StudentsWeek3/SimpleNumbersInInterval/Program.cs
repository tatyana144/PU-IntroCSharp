using System;

namespace SimpleNumbersInInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter m = ");
            int m = int.Parse(Console.ReadLine());

            for (int num = n; num < m; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);

                while (divider <= maxDivider)
                {
                    if(num % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
