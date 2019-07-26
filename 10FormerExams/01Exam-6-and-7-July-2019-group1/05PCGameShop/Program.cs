using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double hearthstonePercent = 0;
            double fornitePercent = 0;
            double overwatchPercent = 0;
            double others = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                switch (name)
                {
                    case "Hearthstone": hearthstonePercent += 1; break;
                    case "Fornite": fornitePercent += 1; break;
                    case "Overwatch": overwatchPercent += 1; break;

                    default:
                        others += 1; break;
                }
            }

            hearthstonePercent = 100 * hearthstonePercent / n;
            fornitePercent = 100 * fornitePercent / n;
            overwatchPercent = 100 * overwatchPercent / n;
            others = 100 * others / n;

            Console.WriteLine($"Hearthstone - {hearthstonePercent:f2}%");
            Console.WriteLine($"Fornite - {fornitePercent:f2}%");
            Console.WriteLine($"Overwatch - {overwatchPercent:f2}%");
            Console.WriteLine($"Others - {others:f2}%");

        }
    }
}
