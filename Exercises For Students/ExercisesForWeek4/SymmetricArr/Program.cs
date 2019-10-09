using System;

namespace SymmetricArr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArr = new int[n];

            Console.WriteLine("Enter the values of the array: ");

            for(int i = 0; i < n; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());

            }

            bool symmetric = true;

            for(int i = 0; i < myArr.Length / 2; i++)
            {
                if(myArr[i] != myArr[n-i - 1])
                {
                    symmetric = false;
                    break;
                }
            }

            Console.WriteLine("Symmetric? = ");
        }
    }
}
