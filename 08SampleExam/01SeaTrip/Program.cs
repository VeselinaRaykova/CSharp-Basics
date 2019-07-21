using System;

namespace _01SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double souvenirsMoney = double.Parse(Console.ReadLine());
            double hotelPerDay = double.Parse(Console.ReadLine());

            double fuelMoney = 2*2.10 * 7 * 1.85;
            double hotelMoney = 0;
            double totalMoney = 0;

            hotelMoney = hotelPerDay * 0.9 + hotelPerDay * 0.85 + hotelPerDay * 0.80;

            totalMoney = hotelMoney + fuelMoney + 3 * souvenirsMoney + 3 * foodMoney;

            Console.WriteLine($"Money needed: {totalMoney:f2}");
        }
    }
}
