using System;

namespace _02NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            for (int row = 1; row <= n; row++)
            {

                for (int col = 1; col <= row; col++)
                {
                    if (number > n)
                    {
                        return;
                    }

                    Console.Write($"{number} ");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
