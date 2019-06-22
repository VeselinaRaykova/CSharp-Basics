using System;

namespace _07HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());


            double frontWalls = 2 * x * x - (1.2 * 2);
            double sideWalls = 2 * x * y - 2 * (1.5 * 1.5);
            double frontRoot = x * h;
            double sideRoof = 2 * x * y;
            double greenPaint = (frontWalls + sideWalls) / 3.4;
            double redPaint = (frontRoot + sideRoof) / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");


        }
    }
}
