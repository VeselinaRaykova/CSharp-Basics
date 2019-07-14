using System;

namespace _04EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int currSum = num1 + num2;
            int prevSum = currSum;
            int maxDiff = 0;

            for (int i = 1; i < n; i++)
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                currSum = num1 + num2;
                if (Math.Abs(currSum - prevSum) > maxDiff)
                {
                    maxDiff = Math.Abs(currSum - prevSum);
                }

                prevSum = currSum;
            }

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={currSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
