using System;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            string action;
            double currentSum = 0;
            int totalDays = 0;
            int daysSpending = 0;

            while (availableMoney < neededMoney)
            {
                action = Console.ReadLine();
                currentSum = double.Parse(Console.ReadLine());
                totalDays++;

                if (action == "spend")
                {
                    availableMoney = availableMoney - currentSum > 0 ? availableMoney - currentSum : 0;
                    daysSpending++;
                    if (daysSpending == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(totalDays);
                        return;
                    }
                }
                else
                {
                    availableMoney += currentSum;
                    daysSpending = 0;
                }
            }

            Console.WriteLine($"You saved the money for {totalDays} days.");

        }
    }
}
