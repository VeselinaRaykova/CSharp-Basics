using System;

namespace _06Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string vacationType = "";
            string destination = "";
            double cost = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    cost = budget * 0.3;
                }
                else
                {
                    cost = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    cost = budget * 0.4;
                }
                else
                {
                    cost = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                cost = budget * 0.9;
            }

            if (season == "summer" && budget <= 1000)
            {
                vacationType = "Camp";
            }
            else
            {
                vacationType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {cost:f2}");
        }
    }
}
