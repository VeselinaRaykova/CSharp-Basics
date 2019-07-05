using System;

namespace _01OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            int booksCount = int.Parse(Console.ReadLine());
            string nextBook;
            int counter = 0;

            while (counter < booksCount)
            {
                nextBook = Console.ReadLine();
                if (wantedBook == nextBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    return;
                }

                counter++;
            }

            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {booksCount} books.");

        }
    }
}
