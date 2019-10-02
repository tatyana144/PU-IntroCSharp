using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNumberDiapason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int myNumber = int.Parse(Console.ReadLine());
            if (myNumber < 100)
            {
                Console.WriteLine("Your number is less than 100");
            } else if(myNumber>100 && myNumber<200)
                {
                Console.WriteLine("Your number is between 100 and 200");
                 }else if (myNumber>200)
            {
                Console.WriteLine("Your number is bigger than 200");
            }
           


        }
    }
}
