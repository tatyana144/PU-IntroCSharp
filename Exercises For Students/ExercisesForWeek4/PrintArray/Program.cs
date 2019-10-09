using System;

namespace PrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArr = { "one", "two", "three", "four",};
            for(int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine($"{myArr[i]}");
            }
        }
    }
}
