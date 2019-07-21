using System;

namespace _04BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededMoney = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double couvert;
            double collectedMoney = 0;
            int guests = 0;

            while (command != "The restaurant is full")
            {
                int group = int.Parse(command);
                guests += group;
                couvert = group < 5 ? 100 : 70;
                collectedMoney += group * couvert;

                command = Console.ReadLine();
            }

            if (collectedMoney >= neededMoney)
            {
                Console.WriteLine($"You have {guests} guests and {collectedMoney - neededMoney} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {guests} guests and {collectedMoney} leva income, but no singer.");
            }
        }
    }
}
