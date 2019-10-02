using System;
using System.Text;

namespace HowMuchIsX
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding utf8 = Encoding.UTF8;

            Console.WriteLine("Enter a : ");
            double a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b : ");
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter c : ");
            double c = int.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - (4*a*c);
            double x1;
            double x2;

            if (a == 0)
            {
              if(b == 0)
                {
                    if(c ==0)
                    {
                        Console.WriteLine("Всяко х е решение!");
                    }
                    else
                    {
                        Console.WriteLine("Уравнението няма решение");
                    }
                }
              else
                {
                    x1 =  (- c/b);
                    Console.WriteLine("Уравнението има само едно решение");
                    Console.WriteLine("х = {0}", x1);
                }
            }
            else
            {
                if (discriminant > 0)
                {
                    x1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
                    x2 = ((-b - Math.Sqrt(discriminant)) / (2 * a));
                    Console.WriteLine("Квадратното уравнение има два различни корена.");
                    Console.WriteLine("x1 = {0} and x2 = {1}", x1, x2);
                }
                else if (discriminant == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Квадратното уравнение има един корена.");
                    Console.WriteLine("x = {0} ", x1);
                }
                else
                {
                    Console.WriteLine("Квадратното уравнение няма корени.");
                }
            }
        }
    }
}
