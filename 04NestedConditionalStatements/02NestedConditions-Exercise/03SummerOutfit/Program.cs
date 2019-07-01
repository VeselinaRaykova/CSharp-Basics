using System;

namespace _03SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            string shoes = "";
            string outfit = "";

            if (degrees >= 10 && degrees <= 18)
            {

                if (partOfTheDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else //if (partOfTheDay == "Afternoon" || partOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (partOfTheDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else //if (partOfTheDay == "Morning" || partOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees >= 25)
            {
                switch (partOfTheDay)
                {
                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals"; break;
                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot"; break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins"; break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

        }
    }
}
