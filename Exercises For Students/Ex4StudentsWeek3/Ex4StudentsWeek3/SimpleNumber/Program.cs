using System;

namespace SimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number");
            int number = int.Parse(Console.ReadLine());

            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);

            bool prime = true;

            while (prime && (divider <= maxDivider))
            {
                if(number % 2 == 0)
                {
                    prime = false;
                }

                divider++;
            }

            Console.WriteLine("Is the number simple? " + prime);
        }
    }
}
