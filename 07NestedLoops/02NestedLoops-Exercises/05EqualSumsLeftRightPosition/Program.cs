using System;

namespace _05EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int number = firstNumber; number <= secondNumber; number++)
            {
                int dig1 = number % 10;
                int dig2 = number / 10 % 10;
                int dig3 = number / 100 % 10;
                int dig4 = number / 1000 % 10;
                int dig5 = number / 10000 % 10;

                int leftSum = dig1 + dig2;
                int rightSum = dig4 + dig5;

                if (rightSum < leftSum)
                {
                    rightSum += dig3;
                }
                else if (leftSum < rightSum)
                {
                    leftSum += dig3;
                }

                if (leftSum == rightSum)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
