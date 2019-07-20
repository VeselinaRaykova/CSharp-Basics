using System;

namespace _07NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSum = int.MinValue;
            string winner = "";

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "STOP")
                {
                    break;
                }
                else
                {
                    string name = command;
                    int sum = 0;

                    for (int i = 0; i < name.Length; i++)
                    {
                        sum += name[i];
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            winner = name;
                        }
                    }
                }
            }

            Console.WriteLine($"Winner is {winner} - {maxSum}!");
        }
    }
}
