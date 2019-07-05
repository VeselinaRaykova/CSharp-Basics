using System;

namespace _06Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int years = 12;
            double grade = 0;
            double sum = 0;
            double averageGrade = 0;

            while (years > 0)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    continue;
                }
                sum += grade;

                years--;
            }

            averageGrade = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}