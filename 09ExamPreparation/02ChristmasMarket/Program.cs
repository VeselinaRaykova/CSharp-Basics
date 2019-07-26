using System;

namespace _02ChristmasMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            int fantasyQuantity = int.Parse(Console.ReadLine());
            int horrorQuantity = int.Parse(Console.ReadLine());
            int romanceQuantity = int.Parse(Console.ReadLine());

            double fantasyPrice = 14.90;
            double horrorPrice = 9.80;
            double romancePrice = 4.30;

            double collectedMoney = fantasyQuantity * fantasyPrice + horrorQuantity * horrorPrice + romanceQuantity * romancePrice;
            collectedMoney = 0.8 * collectedMoney;

            if (collectedMoney < neededMoney)
            {
                Console.WriteLine($"{neededMoney - collectedMoney:f2} money needed.");
            }
            else
            {
                int comission = (int)(0.1 * (collectedMoney - neededMoney));
                Console.WriteLine($"{collectedMoney - comission:f2} leva donated.");
                Console.WriteLine($"Sellers will receive {comission} leva.");
            }
        }
    }
}
