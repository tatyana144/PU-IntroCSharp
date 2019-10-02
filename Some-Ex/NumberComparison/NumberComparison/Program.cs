using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Conditional(firstNumber,secondNumber);
        }
        static void Conditional(int firstNumber, int secondNumber)
        {
            if (firstNumber>secondNumber)
            {
                Console.WriteLine("{0} is greater than {1}", firstNumber,secondNumber);
            }else if (firstNumber<secondNumber)
            {
                Console.WriteLine("{0} is greater than {1}",secondNumber,firstNumber);
            }else if (firstNumber==secondNumber)
            {
                Console.WriteLine("{0} is equal to {1}", firstNumber,secondNumber);
            }

        }
    }
}
