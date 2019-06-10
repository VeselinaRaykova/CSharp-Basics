using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double cost = meters * 7.61;
            double discount = 0.18 * cost;
            cost -= discount;

            Console.WriteLine($"The final price is: {cost:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
