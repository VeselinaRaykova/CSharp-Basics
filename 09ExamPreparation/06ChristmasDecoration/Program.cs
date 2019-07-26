using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ChristmasDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string toy = Console.ReadLine();
            int price = 0;

            while (toy != "Stop")
            {
                price = 0;

                for (int i = 0; i < toy.Length; i++)
                {
                    price += (int)toy[i];
                }

                budget -= price;
                if (budget >= 0)
                {
                    Console.WriteLine($"Item successfully purchased!");
                }
                else
                {
                    Console.WriteLine($"Not enough money!");
                    return;
                }

                toy = Console.ReadLine();
            }

            Console.WriteLine($"Money left: {budget}");
        }
    }
}
