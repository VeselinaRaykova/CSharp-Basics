using System;

namespace _07WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine()); //in seconds
            double distanceInM = double.Parse(Console.ReadLine()); //in meters
            double secondsPerM = double.Parse(Console.ReadLine()); //per meters
            
            double currentTime = distanceInM * secondsPerM + 12.5 * (int)(distanceInM / 15);
            double diff = Math.Abs(currentTime - recordTime);

            if (currentTime < recordTime )
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {currentTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(diff):f2} seconds slower.");
            }

        }
    }
}
