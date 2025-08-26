using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp1
{
    internal class DayOfYear
    {
        public DayOfYear() 
        {
            Console.WriteLine("DayOfYear Example:");

            DateTime date = new DateTime(2025, 1, 15);
            int dayOfYear = date.DayOfYear;

            // Output the result to the console 
            Console.WriteLine($"The day of the year for {date.ToShortDateString()} is {dayOfYear}.");   // The day of the year for 6/15/2024 is 167.
        }
    }
}
