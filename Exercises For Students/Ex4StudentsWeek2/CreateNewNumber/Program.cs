using System;

namespace CreateNewNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number with 5 digits: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number with 7 digits: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int secondDigit = (firstNumber / 100) %10;
            int fourthDigit = (secondNumber / 100) % 10;

            Console.WriteLine("The new number is : {0}{1}", secondDigit, fourthDigit);
        }
    }
}
