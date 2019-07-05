using System;

namespace _03AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double currentPayment = 0;
            double balance = 0;
            double counter = 0;

            while (counter < n)
            {
                currentPayment = double.Parse(Console.ReadLine());
                if (currentPayment < 0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }

                balance += currentPayment;
                Console.WriteLine($"Increase: {currentPayment:f2}");
                counter += 1;
            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
