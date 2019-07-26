using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double minRating = int.MaxValue;
            string minRatingMovie = "";
            double maxRating = int.MinValue;
            string maxRatingMovie = "";
            double averageRating = 0;

            for (int i = 0; i < count; i++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                if (minRating > rating)
                {
                    minRating = rating;
                    minRatingMovie = movieName;
                }
                if (maxRating < rating)
                {
                    maxRating = rating;
                    maxRatingMovie = movieName;
                }

                averageRating += rating;
            }

            averageRating /= count;

            Console.WriteLine($"{maxRatingMovie} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minRatingMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
