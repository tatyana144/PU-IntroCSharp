using System;

namespace WithForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArr = new string[] { "Sofia", "Washington", "London", "Paris"};

            foreach (string capital in myArr)
            {
                Console.WriteLine(capital);
            }
        }
    }
}
