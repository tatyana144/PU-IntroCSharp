﻿using System;

namespace ConversionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            int[] a = new int[10];

            Console.Write("Enter number to convert ");
            n = int.Parse(Console.ReadLine());

            for( i = 0; 0 < n; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number= ");
            for(i= i-1; i >=0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
