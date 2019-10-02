using System;

namespace SimpleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 3;
            int second = 5;

            if (first > second)
            {
                Console.WriteLine("{0} is bigger than {1}", first, second);
            }
            else
            {
                Console.WriteLine("{0} is bigger than {1}", second, first);
            }
        }
    }
}
