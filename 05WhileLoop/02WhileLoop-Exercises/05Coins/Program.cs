using System;

namespace _05Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine()) * 100;
            int coins = 0;
            int[] coinTypes = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int coin in coinTypes)
            {
                while (change >= coin)
                {
                    coins++;
                    change -= coin;
                }

                if (change == 0)
                {
                    break;
                }
            }

            Console.WriteLine(coins);
        }
    }
}
