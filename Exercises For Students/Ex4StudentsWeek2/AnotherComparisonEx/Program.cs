using System;

namespace AnotherComparisonEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 5;
            int secondNum = 3;

            if (firstNum == secondNum)
            {
                Console.WriteLine("These two numbers are equal.");
            }
            else
            {
                if (firstNum > secondNum)
                {
                    Console.WriteLine("The first number is greater.");
                }
                else
                {
                    Console.WriteLine("The second number is greater.");
                }
            }
        }
    }
}
