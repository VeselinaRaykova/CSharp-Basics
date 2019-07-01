using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double pricePerNight = 0;
            double discount = 0;
            double totalPrice = 0;

            if (roomType == "room for one person")
            {
                pricePerNight = 18;
            }
            else if (roomType == "apartment")
            {
                pricePerNight = 25;
                if (days < 10)
                {
                    discount = 0.3;
                }
                else if (days >= 10 && days < 15)
                {
                    discount = 0.35;
                }
                else if (days >= 15)
                {
                    discount = 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                pricePerNight = 35;
                if (days < 10)
                {
                    discount = 0.1;
                }
                else if (days >= 10 && days < 15)
                {
                    discount = 0.15;
                }
                else if (days >= 15)
                {
                    discount = 0.20;
                }
            }

            totalPrice = days * pricePerNight;
            totalPrice -= totalPrice * discount;

            if (rating == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else
            {
                totalPrice -= totalPrice * 0.1;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
