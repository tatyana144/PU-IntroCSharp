using System;

namespace ComparisonEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("{0} is grater than {1}", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0} is grater than {1}", secondNumber, firstNumber);
            }
        }
    }
}
