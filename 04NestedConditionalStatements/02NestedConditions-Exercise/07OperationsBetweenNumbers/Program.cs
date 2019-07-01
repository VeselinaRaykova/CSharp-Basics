using System;

namespace _07OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0;
            string evenOrOdd = "";

            if (operation == "+")
            {
                result = n1 + n2;
                evenOrOdd = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} {operation} {n2} = {result} - {evenOrOdd}");
            }
            else if (operation == "-")
            {
                result = n1 - n2;
                evenOrOdd = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} {operation} {n2} = {result} - {evenOrOdd}");
            }
            else if (operation == "*")
            {
                result = n1 * n2;
                evenOrOdd = result % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"{n1} {operation} {n2} = {result} - {evenOrOdd}");
            }
            else if (operation == "/")
            {
                if (n2 != 0)
                {
                    result = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }

            }
            else if (operation == "%")
            {
                if (n2 != 0)
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }

        }
    }
}
