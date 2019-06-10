using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());

            double costs = dogs * 2.5 + animals * 4;
            Console.WriteLine($"{costs:f2} lv.");
        }
    }
}
