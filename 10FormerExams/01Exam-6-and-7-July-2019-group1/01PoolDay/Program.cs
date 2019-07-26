using System;

namespace _01PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double bedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            int umbrellas = (int)Math.Ceiling(people / 2m);
            int beds = (int)Math.Ceiling(people * 0.75);

            double neededMoney = tax * people + umbrellas * umbrellaPrice + beds * bedPrice;

            Console.WriteLine($"{neededMoney:f2} lv.");
        }
    }
}
