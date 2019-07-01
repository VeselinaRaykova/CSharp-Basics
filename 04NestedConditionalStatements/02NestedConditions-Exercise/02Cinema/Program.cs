using System;

namespace _02Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double ticketPrice = 0;
            double income = 0;
            
            if (projectionType=="Premiere")
            {
                ticketPrice = 12;
            }
            else if (projectionType=="Normal")
            {
                ticketPrice = 7.50;
            }
            else if (projectionType=="Discount")
            {
                ticketPrice = 5;
            }

            income = rows * cols*ticketPrice;

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
