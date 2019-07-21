using System;

namespace _06MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int firstDigit = int.Parse(number[2].ToString());
            int secondDigit = int.Parse(number[1].ToString());
            int thirdDigit = int.Parse(number[0].ToString());

            for (int a = 1; a <= firstDigit; a++)
            {
                for (int b = 1; b <= secondDigit; b++)
                {
                    for (int c = 1; c <= thirdDigit; c++)
                    {
                        Console.WriteLine($"{a} * {b} * {c} = {a * b * c};");
                    }
                }
            }
        }
    }
}
