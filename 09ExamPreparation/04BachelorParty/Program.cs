using System;

namespace _04BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyForMusic = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int group = 0;
            int guests = 0;
            int couvert = 0;
            int collectedMoney = 0;

            while (input != "The restaurant is full")
            {
                group = int.Parse(input);
                couvert = group < 5 ? 100 : 70;
                collectedMoney += couvert * group;

                guests += group;
                input = Console.ReadLine();
            }

            if (collectedMoney >= moneyForMusic)
            {
                Console.WriteLine($"You have {guests} guests and {collectedMoney - moneyForMusic} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {guests} guests and {collectedMoney} leva income, but no singer.");
            }

        }
    }
}
