using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp1
{
    internal class DayOfYear2
    {
        public DayOfYear2() 
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("yyyy/MM/dd"));

            DateTime startOfYear = new DateTime(today.Year, 1, 1);
            Console.WriteLine(startOfYear.ToString("yyyy/MM/dd"));

            int dayOfYear = (today - startOfYear).Days + 1;
            Console.WriteLine($"Today is the {dayOfYear} day of the year.");
        }
    }
}
