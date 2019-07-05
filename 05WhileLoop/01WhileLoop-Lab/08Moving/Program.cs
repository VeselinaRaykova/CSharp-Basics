using System;

namespace _08Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * lenght * height;
            string command = Console.ReadLine();
            int boxesVolume = 0;

            while (command != "Done")
            {
                boxesVolume = int.Parse(command);
                volume -= boxesVolume;
                if (volume < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{volume} Cubic meters left.");

        }
    }
}
