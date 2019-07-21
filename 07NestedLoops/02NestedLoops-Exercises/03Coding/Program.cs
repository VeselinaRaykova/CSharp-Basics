using System;

namespace _03Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char currentChar = number[i];
                if (currentChar == '0')
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                int currentNumber = int.Parse(currentChar.ToString());

                for (int k = 0; k < currentNumber; k++)
                {
                    Console.Write((char)(currentNumber + 33));
                }

                Console.WriteLine();
            }
        }
    }
}
