using System;

namespace PriceForTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance: ");
            double distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter when:");
            string dayOrNigth = Console.ReadLine();

            double taxiRate = 0;
            double priceTaxi = 0;
            double priceTrain = 0;
            double priceBus = 0;
            double price = 0;



            //if (dayOrNigth == "day") // if and switch construction work correct! You choose with wich to work
            //{
            //    taxiRate =  0.79;

            //}
            //else
            //{
            //    taxiRate =  0.90;
            //}

            switch (dayOrNigth)
            {
                case "day": taxiRate = 0.79;
                    break;
                case "nigth": taxiRate = 0.90;
                    break;
                default: Console.WriteLine("Something else");
                    break;

            }

            if (distance < 20)
            {
                price = 0.70 + (distance * taxiRate);
                Console.WriteLine("With taxi for {0}", price);
            }
            else if(distance >= 20 && distance < 100)
            {
                priceTaxi = (0.70 + ( distance * taxiRate));
                priceBus = (distance * 0.9);
                if(priceTaxi < priceBus)
                {
                    price = priceTaxi;
                    Console.WriteLine("With taxi: {0}, with bus: {1}", priceTaxi, priceBus);
                    Console.WriteLine("With taxi for {0}", price);
                }
                else
                {
                    price = priceBus;
                    Console.WriteLine("With taxi: {0}, with bus: {1}", priceTaxi, priceBus);
                    Console.WriteLine("With bus for {0}", price);
                }
            }
            else
            {
                priceTaxi = (0.70 + (distance * taxiRate));
                priceBus = (distance * 0.9);
                priceTrain = (distance * 0.6);
                if(priceTaxi < priceBus && priceTaxi < priceTrain)
                {
                    
                    price = priceTaxi;
                    Console.WriteLine("With taxi: {0}, with bus: {1}, with train: {2}", priceTaxi, priceBus, priceTrain);
                    Console.WriteLine("With taxi for {0}", price);

                }
                else if (priceBus < priceTaxi && priceBus < priceTrain)
                {
                    price = priceBus;
                    Console.WriteLine("With taxi: {0}, with bus: {1}, with train: {2}", priceTaxi, priceBus, priceTrain);
                    Console.WriteLine("With bus for {0}", price);
                }
                else
                {
                    price = priceTrain;
                    Console.WriteLine("With taxi: {0}, with bus: {1}, with train: {2}", priceTaxi, priceBus, priceTrain);
                    Console.WriteLine("With train for {0}", price);
                }
            }
        }
    }
}
