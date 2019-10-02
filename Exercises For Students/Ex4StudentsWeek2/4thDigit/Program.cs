using System;

namespace _4thDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number with seven digits here: ");
            int digits = int.Parse(Console.ReadLine());
            int fourthNumber = (digits/100) % 10;
            Console.WriteLine("The fourth digit is {0}", fourthNumber);

        }
    }
}
