using System;

namespace SwitchCaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter what season you were born.");
            string favSeason = Console.ReadLine();

            switch(favSeason)
            {
                case "spring": Console.WriteLine("You are a very positive person."); break;
                case "summer": Console.WriteLine("You are a very temperamental person."); break;
                case "autumn": Console.WriteLine("You are a generous person."); break;
                case "winter": Console.WriteLine("You are unpredictable and difficult person"); break;
                default: Console.WriteLine("I don't know which is that season."); break;
            }
        }
    }
}
