using System;

namespace _01PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isOverX = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            bool isOverY = (y == y1 || y == y2) && (x >= x1 && x <= x2);

            if (isOverX || isOverY)
            {
                Console.WriteLine("Border");
            }
            else //if (x > x1 && x < x2 && y > y1 && y < y2)
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
