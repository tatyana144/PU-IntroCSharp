using System;

namespace ColoredString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter random string: ");
            string randomString = Console.ReadLine();

            Console.WriteLine("Choose color: r for Red, g for green or y for yellow");
            char color = Convert.ToChar(Console.ReadLine());

            if (color == 'r')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(randomString);
            }
            else if(color == 'g')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(randomString);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(randomString);
            }
        }
    }
}
