using System;

namespace _03SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            if (restaurant == "Sushi Zone")
            {
                switch (sushiType)
                {
                    case "sashimi": price = 4.99; break;
                    case "maki": price = 5.29; break;
                    case "uramaki": price = 5.99; break;
                    case "temaki": price = 4.29; break;
                }
            }
            else if (restaurant == "Sushi Time")
            {
                switch (sushiType)
                {
                    case "sashimi": price = 5.49; break;
                    case "maki": price = 4.69; break;
                    case "uramaki": price = 4.49; break;
                    case "temaki": price = 5.19; break;
                }
            }
            else if (restaurant == "Sushi Bar")
            {
                switch (sushiType)
                {
                    case "sashimi": price = 5.25; break;
                    case "maki": price = 5.55; break;
                    case "uramaki": price = 6.25; break;
                    case "temaki": price = 4.75; break;
                }
            }
            else if (restaurant == "Asian Pub")
            {
                switch (sushiType)
                {
                    case "sashimi": price = 4.50; break;
                    case "maki": price = 4.80; break;
                    case "uramaki": price = 5.50; break;
                    case "temaki": price = 5.50; break;
                }
            }
            else
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
                return;
            }

            totalPrice = price * count;

            if (order.ToLower() == "y")
            {
                totalPrice += 0.2 * totalPrice;
            }

            Console.WriteLine($"Total price: {Math.Ceiling(totalPrice)} lv.");
        }
    }
}
