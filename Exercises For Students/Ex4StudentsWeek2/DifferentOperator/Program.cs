using System;

namespace DifferentOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What you will enter: I for  number and d,  S for string ");
            char something = char.Parse(Console.ReadLine());

            switch (something)
            {
                case 'I':
                    Console.WriteLine("Enter number I");
                    double number = double.Parse(Console.ReadLine());
                    double newNumber = number + 1;
                    Console.WriteLine("The number is {0} and the new number is {1}", number, newNumber);
                    break;
                case 'S':
                    Console.WriteLine("Enter some word");
                    string word = Console.ReadLine();
                    string newWord = word + "*";
                    Console.WriteLine("The word is {0} and the new word is {1}", word, newWord);
                    break;
                default: Console.WriteLine("Error");
                    break;
            }
        }
    }
}
