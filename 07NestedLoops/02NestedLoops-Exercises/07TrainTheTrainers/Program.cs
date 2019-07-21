using System;

namespace _07TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double presentationAverage = 0;
            double totalAverage = 0;
            int presentationsCount = 0;
            double grade = 0;

            while (presentationName.ToLower() != "finish")
            {
                presentationsCount++;

                for (int i = 0; i < n; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    presentationAverage += grade;
                }

                presentationAverage /= n;
                totalAverage += presentationAverage;
                Console.WriteLine($"{presentationName} - {presentationAverage:f2}.");

                presentationName = Console.ReadLine();
                presentationAverage = 0;
            }

            totalAverage /= presentationsCount;
            Console.WriteLine($"Student's final assessment is {totalAverage:f2}.");
        }
    }
}
