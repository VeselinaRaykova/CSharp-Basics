using System;

namespace _05TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine())*100; //in m
            double height = double.Parse(Console.ReadLine())*100; //in m
            height -= 100;

            int rows = (int)(width / 120);
            int desksPerRow = (int)(height / 70);
            int desks = rows * desksPerRow - 3;

            Console.WriteLine(desks);
        }
    }
}
