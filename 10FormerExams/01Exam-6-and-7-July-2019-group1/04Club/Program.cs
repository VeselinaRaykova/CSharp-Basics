using System;

namespace _04Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine());
            string orderName = Console.ReadLine();
            double orderPrice = 0;
            int count = 0;
            double income = 0;

            while (true)
            {
                if (orderName == "Party!")
                {
                    Console.WriteLine($"We need {target - income:f2} leva more.");
                    break;
                }

                count = int.Parse(Console.ReadLine());
                orderPrice = orderName.Length * count;

                if (orderPrice % 2 != 0)
                {
                    orderPrice *= 0.75;
                }

                income += orderPrice;
                if (income >= target)
                {
                    Console.WriteLine($"Target acquired.");
                    break;
                }

                orderName = Console.ReadLine();
            }

            Console.WriteLine($"Club income - {income:f2} leva.");

        }
    }
}
