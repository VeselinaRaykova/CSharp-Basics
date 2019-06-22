using System;

namespace _01SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int secFirst = int.Parse(Console.ReadLine());
            int secSecond = int.Parse(Console.ReadLine());
            int secThird = int.Parse(Console.ReadLine());

            int time = secFirst + secSecond + secThird;
            int minutes = time / 60;
            int seconds = time % 60;

            if (seconds <= 9)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
                return;
            }
            Console.WriteLine($"{minutes}:{seconds}");

        }
    }
}
