using System;

namespace AgeAfterTenYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you? ");
            int myAge = int.Parse(Console.ReadLine());
            int myAgeAfterTenYears = myAge + 10;
            Console.WriteLine("You will be {0} years old after 10 years.", myAgeAfterTenYears);
        }
    }
}
