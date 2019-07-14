using System;

namespace _08CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double neededMoney = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toys = 0;
            int money = 0;
            int brotherMoney = 0;
            double totalMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10 * i / 2;
                    brotherMoney += 1;
                }
                else
                {
                    toys += 1;
                }
            }

            totalMoney = money - brotherMoney + toys * toyPrice;

            if (totalMoney < neededMoney)
            {
                Console.WriteLine($"No! {neededMoney - totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"Yes! {totalMoney - neededMoney:f2}");
            }
        }
    }
}
