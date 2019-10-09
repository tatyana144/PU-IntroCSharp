﻿using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            // Get array size
            int length = array.Length;

            // Declare and create the reversed array
            int[] reversed = new int[length];

            // Initialize the reversed array
            for (int index = 0; index < length; index++)
            {
                reversed[length - index -1 ] = array[index];
            }

            for (int index = 0; index < length; index++)
            {
                Console.WriteLine(reversed[index] + " ");
            }

        }
    }
}
