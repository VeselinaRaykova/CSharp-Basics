using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskeyPrice = double.Parse(Console.ReadLine()); //lv
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double wiskey = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskeyPrice / 2;
            double winePrice = rakiaPrice * 0.60; //rakiaPrice - rakiaPrice * 0.40
            double beerPrice = rakiaPrice * 0.20;
            double money = beer * beerPrice + wine * winePrice + rakia * rakiaPrice + wiskey * wiskeyPrice;

            Console.WriteLine($"{money:f2}");
        }
    }
}
