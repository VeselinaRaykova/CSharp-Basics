using System;

namespace _08HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double appPrice = 0;
            double studioPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                appPrice = 65;
                if (nights > 7 && nights <= 14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.30;

                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                appPrice = 68.70;
                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.20;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                appPrice = 77;
            }

            if (nights > 14)
            {
                appPrice -= appPrice * 0.1;
            }

            Console.WriteLine($"Apartment: {nights * appPrice:f2} lv.");
            Console.WriteLine($"Studio: {nights * studioPrice:f2} lv.");
        }
    }
}
