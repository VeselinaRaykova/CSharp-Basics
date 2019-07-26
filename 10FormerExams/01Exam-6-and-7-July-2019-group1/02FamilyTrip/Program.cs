using System;

namespace _02FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            double costs = double.Parse(Console.ReadLine()) / 100f;

            costs *= budget;

            if (nights > 7)
            {
                pricePerNight = 0.95 * pricePerNight;
            }

            double neededMoney = nights * pricePerNight + costs;

            if (neededMoney <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - neededMoney:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{neededMoney - budget:f2} leva needed.");
            }

        }
    }
}
