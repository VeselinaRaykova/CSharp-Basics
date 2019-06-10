using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            byte projCount = byte.Parse(Console.ReadLine());
            int hours = projCount * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projCount} project/s.");
        }
    }
}
