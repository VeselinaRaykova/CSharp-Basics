using System;

namespace _02ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int receivedBadGrades = 0;
            string command = Console.ReadLine();
            string taskName = "";
            int grade;
            double averageGrade = 0;
            double gradesSum = 0;
            int problemsCount = 0;

            while (command != "Enough")
            {
                taskName = command;
                grade = int.Parse(Console.ReadLine());
                gradesSum += grade;
                problemsCount++;
                if (grade <= 4)
                {
                    receivedBadGrades++;
                    if (receivedBadGrades == badGrades)
                    {
                        Console.WriteLine($"You need a break, {receivedBadGrades} poor grades.");
                        return;
                    }
                }

                command = Console.ReadLine();
            }

            averageGrade = gradesSum / problemsCount;

            Console.WriteLine($"Average score: {averageGrade:f2}");
            Console.WriteLine($"Number of problems: {problemsCount}");
            Console.WriteLine($"Last problem: {taskName}");
        }
    }
}
