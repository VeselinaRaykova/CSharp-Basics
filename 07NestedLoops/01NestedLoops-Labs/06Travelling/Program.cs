using System;

namespace _06Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double neededMoney = 0;
            double savedMoney = 0;

            while (destination != "End")
            {
                neededMoney = double.Parse(Console.ReadLine());

                while (savedMoney < neededMoney)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
                savedMoney = 0;
            }
        }
    }
}
