using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int pieces = width * lenght;
            int takenPieces = 0;
            string command = "";

            while (pieces >= 0)
            {
                command = Console.ReadLine();

                if (command.ToUpper() == "STOP")
                {
                    Console.WriteLine($"{pieces} pieces are left.");
                    return;
                }

                takenPieces = int.Parse(command);
                pieces -= takenPieces;
            }

            Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
        }
    }
}
