using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double squareA = tableLenght / 2;
            double rectA = tableLenght + 2 * 0.30;
            double rectB = tableWidth + 2 * 0.30;
            double sizeSquare = count * (squareA * squareA);
            double sizeRect = count * (rectA * rectB);
            double usd = sizeRect * 7 + sizeSquare * 9;
            double bgn = usd * 1.85;

            Console.WriteLine($"{usd:f2} USD");
            Console.WriteLine($"{bgn:f2} BGN");

        }
    }
}
