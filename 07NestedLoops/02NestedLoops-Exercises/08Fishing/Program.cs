using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double profit = 0;
            string fishName = "";

            for (int i = 1; i <= n; i++)
            {
                fishName = Console.ReadLine();
                if (fishName == "Stop")
                {
                    n = i - 1;
                    break;
                }

                double weight = double.Parse(Console.ReadLine());
                double fishPrice = 0;

                for (int k = 0; k < fishName.Length; k++)
                {
                    fishPrice += (int)(fishName[k]);
                }

                fishPrice /= weight;
                if (i % 3 == 0)
                {
                    profit += fishPrice;
                }
                else
                {
                    profit -= fishPrice;
                }
            }

            if (fishName != "Stop")
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }

            if (profit > 0)
            {
                Console.WriteLine($"Lyubo's profit from {n} fishes is {profit:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {Math.Abs(profit):f2} leva today.");
            }
        }
    }
}
