using System;
using System.Globalization;

namespace _05TimePlus15Minutes_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //string timeToSting = hours + ":" + minutes;
            //DateTime timeToDate = DateTime.ParseExact(timeToSting, "h:mm", CultureInfo.CurrentUICulture );
            //timeToDate = timeToDate.AddMinutes(15);
            //string timePlus15 = timeToDate.ToString("h:mm");

            //Console.WriteLine(timePlus15);
        }
    }
}
