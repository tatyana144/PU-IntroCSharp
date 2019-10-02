using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyBusinessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the requested information!");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Company name:");
            string companyName = Console.ReadLine();
            Console.Write("Company adress:");
            string adress = Console.ReadLine();
            Console.Write("Company phone number:");
            long number = long.Parse(Console.ReadLine());
            Console.Write("Company web site:");
            string web = Console.ReadLine();
            Console.Write("Manager first name:");
            string fName = Console.ReadLine();
            Console.Write("Manager last name:");
            string lName = Console.ReadLine();
            Console.Write("Manager phone number");
            long number2 = long.Parse(Console.ReadLine());
            Console.WriteLine("                           ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("                                  ");
            Console.WriteLine("INFO:                           ");
            Console.WriteLine("Company:                      " + companyName );
            Console.WriteLine("Adress:                       " + adress );
            Console.WriteLine("Company phone number:         " +number);
            Console.WriteLine("Company web site:             " +web);
            Console.WriteLine("Manager:                      " +fName+" "+lName);
            Console.WriteLine("Manager phone number:         " +number2        );
            Console.WriteLine("------------------------------------------");




        }
    }
}
