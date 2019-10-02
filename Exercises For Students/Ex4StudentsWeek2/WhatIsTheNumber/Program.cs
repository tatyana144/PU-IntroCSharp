using System;

namespace WhatIsTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int number = rnd.Next(0,20);
            Console.WriteLine();

            switch (number)
            {
                case 0: Console.WriteLine("{0} - zero", number); break;
                case 1: Console.WriteLine("{0} - one", number);break;
                case 2: Console.WriteLine("{0} - two", number); break;
                case 3: Console.WriteLine("{0} - three", number); break;
                case 4: Console.WriteLine("{0} - four", number); break;
                case 5: Console.WriteLine("{0} - fife", number); break;
                case 6: Console.WriteLine("{0} - six", number); break;
                case 7: Console.WriteLine("{0} - seven", number); break;
                case 8: Console.WriteLine("{0} - eight", number); break;
                case 9: Console.WriteLine("{0} - nine", number); break;
                case 10: Console.WriteLine("{0} - ten", number); break;
                case 11: Console.WriteLine("{0} - eleven", number); break;
                case 12: Console.WriteLine("{0} - twelve", number); break;
                case 13: Console.WriteLine("{0} - thirteen", number); break;
                case 14: Console.WriteLine("{0} - fourteen", number); break;
                case 15: Console.WriteLine("{0} - fifteen", number); break;
                case 16: Console.WriteLine("{0} - sixteen", number); break;
                case 17: Console.WriteLine("{0} - seventeen", number); break;
                case 18: Console.WriteLine("{0} - eighteen", number); break;
                case 19: Console.WriteLine("{0} - nineteen", number); break;
                case 20: Console.WriteLine("{0} - twenty", number); break;
                default: Console.WriteLine("ERROR"); break;


            }
        }
    }
}
