using System;

namespace ConditionalЕxercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = "Monday";
            string begining = "Monday";
            string end = "Sunday";

            if (day == end)
            {
                Console.WriteLine("It is the last day of the week.");
            }
            else if (day == begining)
            {
                Console.WriteLine("It is the first day of the week.");
            }
            else
            {
                Console.WriteLine("It's midweek.");
            }
        }
    }
}
