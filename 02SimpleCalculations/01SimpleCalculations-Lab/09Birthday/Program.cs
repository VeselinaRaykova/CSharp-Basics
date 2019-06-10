using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            byte h = byte.Parse(Console.ReadLine());
            double percentLost = double.Parse(Console.ReadLine());

            double capacityInCm = a * b * h;
            double capacityInLiters = capacityInCm / 1000; //1dm^3 -> 1000cm^3
            double lost = percentLost * capacityInLiters / 100;
            capacityInLiters -= lost;

            Console.WriteLine($"{capacityInLiters:f3}");
        }
    }
}
