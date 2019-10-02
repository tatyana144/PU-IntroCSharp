using System;

namespace WhatCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character: ");
            char character = char.Parse(Console.ReadLine());

            if (char.IsLetter(character))
            {
                if (char.IsLower(character))
                {
                    Console.WriteLine("The character is lowercase.");
                }
                else
                {
                    Console.WriteLine("The character is uppercase.");
                }
            }
            else
            {
                Console.WriteLine("Not an alphabetic character.");
            }

        }
    }
}
