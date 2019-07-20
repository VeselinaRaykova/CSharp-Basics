using System;

namespace _08CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            int flour = 0;
            int eggs = 0;
            int sugar = 0;

            for (int i = 1; i <= parts; i++)
            {
                string product = Console.ReadLine();
                while (product != "Bake!")
                {
                    switch (product)
                    {
                        case "flour": flour++; break;
                        case "eggs": eggs++; break;
                        case "sugar": sugar++; break;
                        default:
                            break;
                    }

                    product = Console.ReadLine();
                }

                if (flour < 1 || eggs < 1 || sugar < 1)
                {
                    Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                    i--;
                }
                else
                {
                    Console.WriteLine($"Baking batch number {i}...");
                    flour = eggs = sugar = 0;
                }
            }
        }
    }
}