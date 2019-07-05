using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Graduation_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int year = 1;
            double grade = 0;
            double averageGrade = 0;
            double gradeSum = 0;
            int fails = 0;

            while (year <= 12)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    gradeSum += grade;
                    fails = 0;

                    year++;
                }
                else
                {
                    fails++;
                    if (fails > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {year} grade");
                        return;
                    }
                }
            }

            averageGrade = gradeSum / 12;

            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");


        }
    }
}
