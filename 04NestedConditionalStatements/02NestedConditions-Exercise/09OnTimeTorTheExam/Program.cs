using System;
using System.Threading;

namespace _09OnTimeTorTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
                //93

                int examHours = int.Parse(Console.ReadLine());
                int examMinutes = int.Parse(Console.ReadLine());
                int studentHours = int.Parse(Console.ReadLine());
                int studentMinutes = int.Parse(Console.ReadLine());

                Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                TimeSpan examTime = new TimeSpan(examHours, examMinutes, 0);
                TimeSpan studentTime = new TimeSpan(studentHours, studentMinutes, 0);
                TimeSpan timeDiff = examTime - studentTime;
                string result = "";

                if (timeDiff.TotalMinutes >= 0 && timeDiff.TotalMinutes <= 30)
                {
                    Console.WriteLine("On time");
                }
                else if (timeDiff.Minutes > 30 || timeDiff.Hours > 0)
                {
                    Console.WriteLine("Early");
                }
                else if (timeDiff.Minutes < 0)
                {
                    Console.WriteLine("Late");
                }

                if (timeDiff.TotalMinutes > 0 && timeDiff.TotalMinutes < 60)
                {
                    result = timeDiff.Minutes.ToString();
                    Console.WriteLine($"{result:mm} minutes before the start");
                }
                else if (timeDiff.Hours > 0)
                {
                    result = timeDiff.ToString("h\\:mm");
                    Console.WriteLine($"{result} hours before the start");
                }
                else if (timeDiff.TotalMinutes < 0 && timeDiff.TotalMinutes > -60)
                {
                    result = (studentTime - examTime).Minutes.ToString();
                    Console.WriteLine($"{result:mm} minutes after the start");
                }
                else if (timeDiff.Hours < 0)
                {
                    result = (studentTime - examTime).ToString("h\\:mm");
                    Console.WriteLine($"{result} hours after the start");
                }
            }
        //}
    }
}