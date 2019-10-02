using System;

namespace SpeedCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance: ");
            double distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose runner: U for Usain Bolt an I for Ivet Lalova!");
            string runner = Console.ReadLine();

            double timeForRuningUsain = (distance / 100) * 9.58;
            double timeForRuningIvet = (distance / 100) * 11.0;

            switch (runner)
            {
                case "U":
                    Console.WriteLine("Usen Bolt will expire {0} meters in {1} seconds", distance, timeForRuningUsain );
                    break;
                case "I":
                    Console.WriteLine("Ivet Lalova will expire {0} meters in {1} seconds", distance, timeForRuningIvet);
                    break;
                default:
                    Console.WriteLine("This player does not exist!");
                    break;
            }
        }
    }
}
