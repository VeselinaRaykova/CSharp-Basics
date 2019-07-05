using System;

namespace _04MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            int max = int.MinValue;

            while (n > 0)
            {
                number = int.Parse(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                }

                n--;
            }

            Console.WriteLine(max);

        }
    }
}
