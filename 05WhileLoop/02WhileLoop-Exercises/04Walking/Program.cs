using System;

namespace _04Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int steps = 0;
            int totalSteps = 0;
            string input = "";

            while (totalSteps < goal)
            {
                input = Console.ReadLine();

                if (input == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    totalSteps += steps;

                    if (totalSteps < goal)
                    {
                        Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
                        return;
                    }

                    break;
                }

                steps = int.Parse(input);
                totalSteps += steps;
            }

            Console.WriteLine("Goal reached! Good job!");
        }
    }
}
