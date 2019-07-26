using System;

namespace _03CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string sugarLevel = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;
            double moneyToPay = 0;

            if (type == "Espresso")
            {
                switch (sugarLevel)
                {
                    case "Without": price = 0.65 * 0.90; break;
                    case "Normal": price = 1; break;
                    case "Extra": price = 1.2; break;
                    default:
                        break;
                }
            }
            else if (type == "Cappuccino")
            {
                switch (sugarLevel)
                {
                    case "Without": price = 0.65 * 1; break;
                    case "Normal": price = 1.2; break;
                    case "Extra": price = 1.6; break;
                    default:
                        break;
                }
            }
            else if (type == "Tea")
            {
                switch (sugarLevel)
                {
                    case "Without": price = 0.65 * 0.5; break;
                    case "Normal": price = 0.6; break;
                    case "Extra": price = 0.7; break;
                    default:
                        break;
                }
            }

            if (type == "Espresso" && count >= 5)
            {
                price *= 0.75;
            }

            moneyToPay = count * price;
            if (moneyToPay > 15)
            {
                moneyToPay *= 0.8;
            }

            Console.WriteLine($"You bought {count} cups of {type} for {moneyToPay:f2} lv.");
        }
    }
}
