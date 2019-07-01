using System;

namespace _04NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double discount = 0;
            double price = 0;
            double cost = 0;
            if (flowers == "Roses")
            {
                price = 5;
                if (count > 80)
                {
                    discount = 0.1;
                }
            }
            else if (flowers == "Dahlias")
            {
                price = 3.80;
                if (count > 90)
                {
                    discount = 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                price = 2.80;
                if (count > 80)
                {
                    discount = 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                price = 3;
                if (count < 120)
                {
                    discount = -0.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                price = 2.50;
                if (count < 80)
                {
                    discount = -0.2;
                }
            }

            cost = count * price;
            cost -= cost * discount;

            if (cost <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {budget - cost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {cost - budget:f2} leva more.");
            }
        }
    }
}
