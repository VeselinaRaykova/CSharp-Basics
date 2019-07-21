using System;

namespace _04EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int number = firstNumber; number <= secondNumber; number++)
            {
                int oddSum = 0;
                int evenSum = 0;
                string numberDigits = number.ToString();

                for (int i = 0; i < numberDigits.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenSum += int.Parse(numberDigits[i].ToString());
                    }
                    else
                    {
                        oddSum += int.Parse(numberDigits[i].ToString());
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
