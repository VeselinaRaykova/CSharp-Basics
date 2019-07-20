using System;

namespace _05Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floor = floors; floor > 0; floor--)
            {
                for (int room = 0; room < rooms; room++)
                {
                    
                    char prefix = ' ';

                    if (floor == floors)
                    {
                        prefix = 'L';
                    }
                    else if (floor % 2 == 0)
                    {
                        prefix = 'O';
                    }
                    else
                    {
                        prefix = 'A';
                    }

                    Console.Write($"{prefix}{floor}{room} ");
                }

                Console.WriteLine();
            }

        }
    }
}
