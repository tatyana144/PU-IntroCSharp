using System;
using System.Text;

namespace SeasonSymbols
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter the season:");
            string season = Console.ReadLine();


            switch(season){
                case "spring":
                    Console.WriteLine();
                    break;
                case "summer":
                    Console.WriteLine("☼");
                    break;
                case "autumn":
                    Console.WriteLine("☼");
                    break;
                case "winter":
                    Console.WriteLine("☼");
                    break;
            }
        }
    }
}
