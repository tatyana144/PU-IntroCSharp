using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 1;
            int secondNumber = 2;
            bool greater = (firstNumber>secondNumber);
            bool equal1 = (firstNumber==1);
            if (greater)
            {
                Console.WriteLine("firstNumber > secondnumber");
            }else
            {
                Console.WriteLine("firstNumber <= secondNumber");
            }
            Console.WriteLine("greater = {0}", greater);
            Console.WriteLine("equal1={0}", equal1);

        }
    }
}
