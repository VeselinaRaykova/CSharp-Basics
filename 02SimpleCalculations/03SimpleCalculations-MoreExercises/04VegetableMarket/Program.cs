using System;

namespace _04VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            double quantityVegetables = double.Parse(Console.ReadLine());
            double quantityFruits = double.Parse(Console.ReadLine());

            double incomeInEUR = (quantityVegetables * priceVegetables + quantityFruits * priceFruits) / 1.94;

            Console.WriteLine($"{incomeInEUR:f2}");
        }
    }
}
