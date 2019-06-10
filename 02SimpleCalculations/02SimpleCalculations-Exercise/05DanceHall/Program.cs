using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l_inMeters = double.Parse(Console.ReadLine()); //in meters
            double w_inMeters = double.Parse(Console.ReadLine()); //in meters
            double a_inMeters = double.Parse(Console.ReadLine()); //in meters
            double l = l_inMeters * 100; //in cm
            double w = w_inMeters * 100; //in cm
            double a = a_inMeters * 100; //in cm


            double roomArea = l * w;
            double wardrobeArea = a * a;
            double benchArea = roomArea * 0.1;
            double freeArea = roomArea - wardrobeArea - benchArea;
            double spacePerPerson = 7040;
            int persons = (int)(freeArea / spacePerPerson);

            Console.WriteLine(persons);
        }
    }
}
