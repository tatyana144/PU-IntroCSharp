using System;

namespace TheSmalestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int firstNum = rnd.Next(0, 100);
            int secondNum = rnd.Next(0,100);
            int thirdNum =  rnd.Next(0,100);

            //if(firstNum < thirtNum)
            //{
            //    if(firstNum < secondNum)
            //    {
            //        Console.WriteLine("{0} {1} {2}", firstNum, secondNum, thirdNum);
            //        Console.WriteLine("The first number is the smallest!");
            //    }
            //    else
            //    {
            //         Console.WriteLine("{0} {1} {2}", firstNum, secondNum,thirdNum);
            //         Console.WriteLine("The second number is the smallest!");
            //    }
            //}
            //else
            //{
            //     Console.WriteLine("{0} {1} {2}", firstNum, secondNum,thirdNum);
            //     Console.WriteLine("The third number is the smallest!");
            //}

            if (firstNum<secondNum && firstNum <thirdNum)
            {
                Console.WriteLine("{0} {1} {2}", firstNum, secondNum,thirdNum);
                Console.WriteLine("The first number is smallest!");
            }
            else
            {
                if (secondNum< firstNum && secondNum <thirdNum)
                {
                    Console.WriteLine("{0} {1} {2}", firstNum, secondNum, thirdNum);
                    Console.WriteLine("The second number is smallest!");
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", firstNum, secondNum, thirdNum);
                    Console.WriteLine("The third number is smallest!");
                }
            }
        }
    }
}
