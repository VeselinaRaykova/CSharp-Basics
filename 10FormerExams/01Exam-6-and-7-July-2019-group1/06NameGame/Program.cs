using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxPoints = int.MinValue;
            int number = 0;
            int points = 0;
            string winner = "";

            while (name != "Stop")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    number = int.Parse(Console.ReadLine());
                    if (number == (int)(name[i]))
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }

                if (points > maxPoints)
                {
                    maxPoints = points;
                    winner = name;
                }

                name = Console.ReadLine();
                points = 0;
            }

            Console.WriteLine($"The winner is {winner} with {maxPoints} points!");
        }
    }
}
