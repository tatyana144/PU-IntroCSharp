using System;

namespace TypeOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three sides of the triangle ");
            Console.WriteLine("Enter a = ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b = ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter c = ");
            double c = double.Parse(Console.ReadLine());

            double perimeter = (a + b + c);

            if (a < 0 || b < 0 || c < 0 )
            {
                Console.WriteLine("The side of a triangle cannot have a negative value!");
            }
            else
            {
                if (a > (b+c) || b > (a + c) || c > (a + b))
                {
                    Console.WriteLine("ERROR");
                }
                else
                {
                    if (a == b && a == c)
                    {
                        Console.WriteLine("The three sides of the triangle are equal.");
                        Console.WriteLine("The perimeter of the triangle is: {0}", perimeter);
                    }
                    else if (a == b || a == c)
                    {
                        Console.WriteLine("The two sides of the triangle are equal.");
                        Console.WriteLine("The perimeter of the triangle is: {0}", perimeter);
                    }
                    else
                    {
                        Console.WriteLine("The triangle do not have equal sides.");
                        Console.WriteLine("The perimeter of the triangle is: {0}", perimeter);
                    }
                }
                
            }

        }
    }
}
