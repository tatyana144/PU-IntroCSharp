using System;

namespace LogIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Enter your email: ");
            string yourEmail = Console.ReadLine();

            Console.WriteLine("Now enter and your password: ");
            string yourPassword = Console.ReadLine();

            switch (yourEmail)
            {
                case "tatyana@abv.bg":
                    switch (yourPassword)
                    {
                        case "pass":
                            Console.WriteLine("Wellcom, {0}", yourEmail);
                            break;
                        default:
                            Console.WriteLine("Incorrect password");
                            break;
                    }
                break;
                case "georgia@abv.bg":
                    switch (yourPassword)
                    {
                        case "passgeorgi":
                            Console.WriteLine("Wellcom, {0}", yourEmail);
                            break;
                        default:
                            Console.WriteLine("Incorrect password");
                            break;
                    }
                 break;
                default:
                    Console.WriteLine("That email does not exist");
                    break;

            }

        }
    }
}
