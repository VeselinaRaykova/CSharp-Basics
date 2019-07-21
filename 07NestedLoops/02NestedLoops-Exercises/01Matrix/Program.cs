using System;

namespace _01Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int a1 = a; a1 <= b; a1++)
            {
                for (int a2 = a; a2 <= b; a2++)
                {
                    for (int b1 = c; b1 <= d; b1++)
                    {
                        for (int b2 = c; b2 <= d; b2++)
                        {
                            if (a1 == a2 || b1 == b2)
                            {
                                continue;
                            }
                            if (a1 + b2 == b1 + a2)
                            {
                                Console.WriteLine($"{a1}{a2}");
                                Console.WriteLine($"{b1}{b2}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
