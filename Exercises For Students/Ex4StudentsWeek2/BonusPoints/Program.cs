using System;


namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter points here: ");
            int points = int.Parse(Console.ReadLine());
            int bonusPoints;
            int totalPoints;

            if (points >= 1 && points <= 3)
            {
                bonusPoints = (points * 10);
                totalPoints = (points + bonusPoints);
                Console.WriteLine("Your points are {0}, your bonus points are {1} and your total points are {2}.", points, bonusPoints, totalPoints);
            }
            else if (points >= 4 && points <= 6)
            {
                bonusPoints = (points * 100);
                totalPoints = (points + bonusPoints);
                Console.WriteLine("Your points are {0}, your bonus points are {1} and your total points are {2}.", points, bonusPoints, totalPoints);
            }
            else if (points >= 7 && points <= 9)
            {
                bonusPoints = (points * 1000);
                totalPoints = (points + bonusPoints);
                Console.WriteLine("Your points are {0}, your bonus points are {1} and your total points are {2}.", points, bonusPoints, totalPoints);
            }
            else
            {
                if (points == 0 || points > 9)
                {
                    Console.WriteLine("Error");
                }
            }
            Console.ReadKey();
        }
    }
}
