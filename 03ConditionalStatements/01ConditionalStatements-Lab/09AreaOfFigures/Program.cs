using System;

namespace _09AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = 0;
            double a, b, r, h;

            if (type == "square")
            {
                a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (type == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (type == "circle")
            {
                r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (type == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                h = double.Parse(Console.ReadLine());
                area = a * h / 2;
            }

            Console.WriteLine($"{area:f3}");
        }
    }
}
