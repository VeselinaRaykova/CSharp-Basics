using System;

namespace _05FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double shipPrice = 0;
            double discount = 0;
            double cost = 0;

            if (season == "Spring")
            {
                shipPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                shipPrice = 4200;
            }
            else
            {
                shipPrice = 2600;
            }

            if (fishermen <= 6)
            {
                discount = 0.1;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                discount = 0.15;
            }
            else if (fishermen >= 12)
            {
                discount = 0.25;
            }
            cost = shipPrice - shipPrice * discount;

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                cost -= cost * 0.05;
            }

            if (cost <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - cost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {cost - budget:f2} leva.");
            }
        }
    }
}
