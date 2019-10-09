using System;

namespace Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            Sum(firstNum,secondNum);

            Subtract(firstNum, secondNum);

            Multiplication(firstNum, secondNum);

            Console.ReadKey();
        }

        public static void Sum(int firstNum, int secondNum)
        {
            int result = (firstNum + secondNum);
            Console.WriteLine($"The sum is {result}");
        }

        public static void Subtract(int first, int second)
        {
            int result = (first - second);
            Console.WriteLine($"Substraction result is {result}");
        }

        public static void Multiplication(int first, int second)
        {
            int result = (first * second);
            Console.WriteLine($"Multiplication result is {result}");
        }
    }
}
