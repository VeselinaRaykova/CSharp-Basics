using System;

namespace _01ChristmasSweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double baklavaPrice = double.Parse(Console.ReadLine());
            double muffinPrice = double.Parse(Console.ReadLine());
            double stollenPrice = 1.6 * baklavaPrice;
            double bonbonsPrice = 1.8 * muffinPrice;
            double biscuitsPrice = 7.50;

            double stollenQuantity = double.Parse(Console.ReadLine());
            double bonbonsQuantity = double.Parse(Console.ReadLine());
            double biscuitsQuantity = double.Parse(Console.ReadLine());

            double neededMoney = stollenQuantity * stollenPrice + bonbonsQuantity * bonbonsPrice + biscuitsQuantity * biscuitsPrice;

            Console.WriteLine($"{neededMoney:f2}");
        }
    }
}
