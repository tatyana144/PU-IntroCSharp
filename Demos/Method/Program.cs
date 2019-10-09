using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter firstNum : ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter secondtNum : ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine();

           double maxNum = GetMaxCalculation(firstNum, secondNum);

            Console.WriteLine($"The biggest number is {maxNum}");
        }

        public static double GetMaxCalculation(double firstNum, double secondNum)
        {
            double theMaxNumber = firstNum;
            if (firstNum < secondNum)
            {
                theMaxNumber = secondNum;
            }
            return theMaxNumber;
        }
    }
}
