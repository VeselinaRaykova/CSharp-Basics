using System;

namespace _05Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stops; i++)
            {
                int leaving = int.Parse(Console.ReadLine());
                int coming = int.Parse(Console.ReadLine());
                people = people - leaving + coming;

                if (i % 2 == 0)
                {
                    people -= 2;
                }
                else
                {
                    people += 2;
                }
            }

            Console.WriteLine($"The final number of passengers is : {people}");
        }
    }
}
