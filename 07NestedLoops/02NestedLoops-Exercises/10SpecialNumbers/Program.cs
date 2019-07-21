using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1111; number <= 9999; number++)
            {
                int n1 = number % 10;
                int n2 = number / 10 % 10;
                int n3 = number / 100 % 10;
                int n4 = number / 1000 % 10;

                if (n1 == 0 || n2==0 || n3==0 || n4==0)
                {
                    continue;
                }

                bool isSpecial = n % n1 == 0 && n % n2 == 0 && n % n3 == 0 && n % n4 == 0;

                if (isSpecial)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
