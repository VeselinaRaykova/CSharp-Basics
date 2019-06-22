using System;


namespace _04MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine()); //in mm
            string metricIn = Console.ReadLine();
            string metricOut = Console.ReadLine();
            double distanceInM = distance;
            double result = 0;

            if (metricIn == "mm")
            {
                distanceInM = distance / 1000;
            }
            else if (metricIn == "cm")
            {
                distanceInM = distance / 100;
            }

            if (metricOut == "m")
            {
                result = distanceInM;
            }
            else if (metricOut == "cm")
            {
                result = distanceInM * 100;
            }
            else if (metricOut == "mm")
            {
                result = distanceInM * 1000;
            }

            Console.WriteLine($"{result:f3}");
        }
    }
}
