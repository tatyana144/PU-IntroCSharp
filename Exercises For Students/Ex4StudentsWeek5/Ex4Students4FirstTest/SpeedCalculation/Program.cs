using System;

namespace SpeedCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have to choose a runner : Ivet Lalova or Usain Bolt!");
            Console.Write("Please enter a runner : ");
            string runnerName = Console.ReadLine();

            string[] splitNameRunner = runnerName.Split(' ');



            Console.WriteLine("----------------------------------------");

            string trackName = " ";


            double mountainLong = 25;
            double roadwayLong = 1000;
            double heavyLong = 15;


            double ivetSpeedForMeter = 100.0 / 10.4;
            double usainSpeedForMeter = 100 / 9.58;

            double mountainHard = Math.Sqrt(mountainLong);
            double roadwayHard = Math.Sqrt(roadwayLong);
            double heavyHard = Math.Sqrt(heavyLong);

            double speedResult = 0;

            switch (splitNameRunner[0])
            {
                case "Ivet":

                    Console.WriteLine("You have to choose also a running track! ");
                    Console.WriteLine("Running Tracks are : mountain track, roadway track, heavy track");
                    Console.Write("Please enter a track : ");
                     trackName = Console.ReadLine();
                    string[] splitNameTrack = trackName.Split(' ');

                    Console.WriteLine("------------------------------------------");

                    if (splitNameTrack[0] == "mountain")
                    {
                        speedResult = (ivetSpeedForMeter * mountainLong) + mountainHard;
                        Console.WriteLine("Ivet Lalova will run the mountain track for {0} seconds.", speedResult);
                    }
                    else if(splitNameTrack[0] == "roadway")
                    {
                        speedResult = (ivetSpeedForMeter * roadwayLong) + roadwayHard;
                        Console.WriteLine("Ivet Lalova will run the roadway track for {0} seconds.", speedResult);
                    }
                    else if(splitNameTrack[0] == "heavy")
                    {
                        speedResult = (ivetSpeedForMeter * heavyLong) + heavyHard;
                        Console.WriteLine("Ivet Lalova will run the heavy track for {0} seconds.", speedResult);
                    }
                    else
                    {
                        Console.WriteLine("Does not exist that track!");
                    }
                    break;
                case "Usain":

                    Console.WriteLine("You have to choose also a running track! ");
                    Console.WriteLine("Running Tracks are : mountain track, roadway, heavy track");
                    Console.Write("Please enter a track :");
                    trackName = Console.ReadLine();
                    splitNameTrack = trackName.Split(' ');


                    Console.WriteLine("------------------------------------------");

                    if (splitNameTrack[0] == "mountain")
                    {
                        speedResult = (usainSpeedForMeter * mountainLong) + mountainHard;
                        Console.WriteLine("Usain Bolt will run the mountain track for {0} seconds.", speedResult);
                    }
                    else if (splitNameTrack[0] == "roadway")
                    {
                        speedResult = (usainSpeedForMeter * roadwayLong) + roadwayHard;
                        Console.WriteLine("Usain Bolt will run the roadway track for {0} seconds.", speedResult);
                    }
                    else if(splitNameTrack[0] == "heavy")
                    {
                        speedResult = (usainSpeedForMeter * heavyLong) + heavyHard;
                        Console.WriteLine("Usain Bolt will run the heavy track for {0} seconds", speedResult);
                    }
                    else
                    {
                        Console.WriteLine("Does not exist that track!");
                    }
                    break;
                default:
                    Console.WriteLine("Does not exist that runner!");
                    break;
            }


            


        }
    }
}
