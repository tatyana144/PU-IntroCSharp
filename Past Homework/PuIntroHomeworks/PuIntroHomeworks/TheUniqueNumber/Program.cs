using System;

namespace TheUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int myAge = int.Parse(Console.ReadLine());
            int myAgeAfterTenYears = myAge + 10;
            Console.WriteLine("Enter last 4 digits of your faculty number here: ");
            int lastFourDigits = int.Parse(Console.ReadLine());
            double myUniqueNumber = (myAgeAfterTenYears * lastFourDigits) / Math.PI;
            Console.WriteLine("After ten years you will be {0} yeras old and your unique number is {1}", myAgeAfterTenYears, myUniqueNumber);
        }
    }
}
