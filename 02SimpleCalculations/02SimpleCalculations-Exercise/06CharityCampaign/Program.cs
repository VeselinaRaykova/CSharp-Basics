using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePrice = 45;
            double wafflePrice = 5.80;
            double pancakePrice = 3.20;

            double bakedPerDay = cakes * cakePrice + waffles * wafflePrice + pancakes * pancakePrice;
            double collectedMoney = days * bakers * bakedPerDay;
            double costs = 1 / 8f * collectedMoney;
            collectedMoney -= costs;

            Console.WriteLine($"{collectedMoney:f2}");

        }
    }
}
