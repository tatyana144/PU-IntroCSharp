using System;

namespace ArrangeTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();


            int firstNum = rnd.Next(0,200);//int.Parse(Console.ReadLine()); 
            int secondNum = rnd.Next(0,200);//int.Parse(Console.ReadLine());
            int thirdNum = rnd.Next(0,200); //int.Parse(Console.ReadLine());

            int max, mid, low;

            if(firstNum <= secondNum && firstNum <= thirdNum)
            {
                if(secondNum >= firstNum && secondNum <= thirdNum)
                {
                    Console.WriteLine("The random numbers are : {0}, {1}, {2}", firstNum, secondNum, thirdNum);
                    low = firstNum;
                    mid = secondNum;
                    max = thirdNum;
                    Console.WriteLine("Arrange numbers are : {0},{1},{2}", low,mid,max);
                }
                else
                {
                    Console.WriteLine("The random numbers are : {0}, {1}, {2}", firstNum, secondNum, thirdNum);
                    low = firstNum;
                    mid = thirdNum;
                    max = secondNum;
                    Console.WriteLine("Arrange numbers are : {0},{1},{2}", low, mid, max);
                }
            }
            else if (secondNum <= firstNum && secondNum <= thirdNum)
            {
                if (firstNum >= secondNum && firstNum <= thirdNum)
                {
                    Console.WriteLine("The random numbers are : {0}, {1}, {2}", firstNum, secondNum, thirdNum);
                    low = secondNum;
                    mid = firstNum;
                    max = thirdNum;
                    Console.WriteLine("Arrange numbers are : {0},{1},{2}", low, mid, max);
                }
                else
                {
                    Console.WriteLine("The random numbers are : {0}, {1}, {2}", firstNum, secondNum, thirdNum);
                    low = secondNum;
                    mid = thirdNum;
                    max = firstNum;
                    Console.WriteLine("Arrange numbers are : {0},{1},{2}", low, mid, max);
                }
            }
            else
            {
                if (thirdNum <= secondNum && thirdNum <= firstNum)
                {
                    if (secondNum >= thirdNum && secondNum >= firstNum )
                    {
                        Console.WriteLine("The random numbers are : {0}, {1}, {2}", firstNum, secondNum, thirdNum);
                        low = thirdNum;
                        mid = firstNum;
                        max = secondNum;
                        Console.WriteLine("Arrange numbers are : {0},{1},{2}", low, mid, max);
                    }
                    else
                    {
                        Console.WriteLine("The random numbers are : {0}, {1}, {2}", firstNum, secondNum, thirdNum);
                        low = thirdNum;
                        mid = secondNum;
                        max = firstNum;
                        Console.WriteLine("Arrange numbers are : {0},{1},{2}", low, mid, max);
                    }
                }

            }

        }
    }
}
