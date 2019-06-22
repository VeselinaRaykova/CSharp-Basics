using System;

namespace _12ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int totalToys = puzzle + dolls + teddyBears + minions + trucks;

            double money = puzzle * 2.6 + dolls * 3 +
                teddyBears * 4.1 + minions * 8.2 + trucks * 2;

            if (totalToys >= 50)
            {
                money -= 0.25 * money;
            }

            money -= 0.1 * money;

            if (money >= tripPrice)
            {
                Console.WriteLine($"Yes! {(money - tripPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(tripPrice - money):f2} lv needed.");
            }
        }
    }
}
