using System;

namespace _08Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScholarship = 0;
            double excellenceScolarship = 0;

            if (income < minSalary && grade > 4.5)
            {
                socialScholarship = 0.35 * minSalary;
            }
            if (grade >= 5.5)
            {
                excellenceScolarship = grade * 25;
            }

            if (socialScholarship == 0 && excellenceScolarship == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (excellenceScolarship >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellenceScolarship)} BGN");
            }
            else //if (socialScholarship > excellenceScolarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
        }
    }
}
