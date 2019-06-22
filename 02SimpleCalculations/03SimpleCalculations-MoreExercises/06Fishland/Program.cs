using System;

namespace _06Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudQuantity = double.Parse(Console.ReadLine()); //in KG
            double safridQuantity = double.Parse(Console.ReadLine());
            double midiQuantity = double.Parse(Console.ReadLine());

            double palamudPrice = skumriaPrice * 1.6;
            double safridPrice = cacaPrice * 1.8;
            double midiPrice = 7.50;

            double check = palamudPrice * palamudQuantity + safridPrice * safridQuantity + midiPrice * midiQuantity;

            Console.WriteLine($"{check:f2}");
        }
    }
}
