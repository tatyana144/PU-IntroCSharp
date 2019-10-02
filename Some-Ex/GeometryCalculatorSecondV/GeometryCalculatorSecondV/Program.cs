using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculatorSecondV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle, square, radians)");
            string option = Console.ReadLine();
            if (option=="triangle")
            {
                Console.WriteLine("Enter side:");
                int side = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter heigh");
                int heigh = int.Parse(Console.ReadLine());
                Triangle(side, heigh);

            }
            if (option=="square")
            {
                Console.WriteLine("Enter side:");
                int side = int.Parse(Console.ReadLine());
                Square(side);
            }
            if (option=="radians")
            {
                Console.WriteLine("Enter the degrees you want to transform in radians:");
               int  degrees = int.Parse(Console.ReadLine());
                Radians(degrees);
            }



        }
        static void Triangle(int side, int heigh)
        {
           
            double area = (side * heigh) / 2;
            Console.WriteLine("The triangle area is = {0:F2}", area);
        }
        static void Square(int side)
        {
           
            double area = Math.Pow(side,2);
            Console.WriteLine("The square area is = {0:F2}", area);
        }
        static void Radians(int degrees)
        {
            double pi = Math.PI;
            double inRadians= (pi / 180) * degrees;
            Console.WriteLine("Your degrees in radians are ={0}", inRadians);
        }
      }
}
