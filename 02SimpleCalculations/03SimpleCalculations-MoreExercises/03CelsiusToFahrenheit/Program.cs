using System;

namespace _03CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreesInC = double.Parse(Console.ReadLine());

            double degreesInF = degreesInC * 1.8 + 32;

            Console.WriteLine($"{degreesInF:f2}");
        }
    }
}
