using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExWithCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            switch(number)
            {
                case 1:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("Числото не е просто!");
                    break;
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Числото е просто!");
                    break;
                default:
                    Console.WriteLine("Не знам какво е това число!");
                    break;
            }
        }
    }
}
