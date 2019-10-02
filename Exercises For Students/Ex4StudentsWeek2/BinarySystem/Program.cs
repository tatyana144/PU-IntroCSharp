using System;

namespace BinarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 35;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine("Binary of the number: " + binary);
        }
    }
}
