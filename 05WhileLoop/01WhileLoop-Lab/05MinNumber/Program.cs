using System;

namespace _05MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            int min = int.MaxValue;

            while (n > 0)
            {
                number = int.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }

                n--;
            }

            Console.WriteLine(min);
        }
    }
}
