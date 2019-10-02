using System;

namespace ForeachEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19};

            foreach (int i in numbers)
            {
                Console.WriteLine(" " + i);
            }

            String[] towns = { "Sofia", "Plovdiv", "Varna"};

            foreach(String town in towns)
            {
                Console.Write(" " + town);
            }
        }
    }
}
