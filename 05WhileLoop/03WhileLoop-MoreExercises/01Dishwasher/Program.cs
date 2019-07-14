using System;


namespace _01Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int dishwasher = 750 * bottles;
            int washerPerPot = 15;
            int washerPerDish = 5;
            int loads = 0;
            int pots = 0;
            int dishes = 0;

            int count;

            while (input != "End")
            {
                count = int.Parse(input);
                loads++;

                if (loads % 3 == 0)
                {
                    dishwasher -= count * washerPerPot;
                    pots += count;
                }
                else
                {
                    dishwasher -= count * washerPerDish;
                    dishes += count;
                }

                if (dishwasher < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(dishwasher)} ml. more necessary!");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
            Console.WriteLine($"Leftover detergent {dishwasher} ml.");
        }
    }
}
