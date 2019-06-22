using System;

namespace _06GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int cast = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine()); //per person

            double decor = budget * 0.1;
            double costs;

            if (cast > 150)
            {
                clothes -= clothes * 0.1;
            }

            costs = decor + cast * clothes;
            
            if (costs > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {costs - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - costs:f2} leva left.");
            }

        }
    }
}
