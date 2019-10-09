using System;

namespace WithForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5};
            Console.WriteLine("Output: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 2 * arr[i];
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
