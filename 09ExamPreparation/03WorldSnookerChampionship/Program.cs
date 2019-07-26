using System;

namespace _03WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            string wantPhoto = Console.ReadLine();

            double ticketPrice = 0;
            double photoPrice = 40;
            double money = 0;

            if (stage == "Quarter final")
            {
                switch (ticketType)
                {
                    case "Standard": ticketPrice = 55.50; break;
                    case "Premium": ticketPrice = 105.20; break;
                    case "VIP": ticketPrice = 118.90; break;
                    default:
                        break;
                }
            }
            else if (stage == "Semi final")
            {
                switch (ticketType)
                {
                    case "Standard": ticketPrice = 75.88; break;
                    case "Premium": ticketPrice = 125.22; break;
                    case "VIP": ticketPrice = 300.40; break;
                    default:
                        break;
                }
            }
            else if (stage == "Final")
            {
                switch (ticketType)
                {
                    case "Standard": ticketPrice = 110.10; break;
                    case "Premium": ticketPrice = 160.66; break;
                    case "VIP": ticketPrice = 400; break;
                    default:
                        break;
                }
            }

            money = ticketsCount * ticketPrice;

            if (money > 4000)
            {
                money -= 0.25 * money;
                photoPrice = 0;
            }
            else if (money > 2500)
            {
                money -= 0.1 * money;
            }

            if (wantPhoto == "Y")
            {
                money += photoPrice * ticketsCount;
            }

            Console.WriteLine($"{money:f2}");
        }
    }
}
