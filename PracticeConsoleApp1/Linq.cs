using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp1
{
    internal class Linq
    {
        //public static void Main(string[] args)
        public Linq()
        {
            Console.WriteLine("LINQ Example:");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Using LINQ to filter even numbers
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;
            Console.WriteLine("Even Numbers:");

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            // Using LINQ method syntax to filter odd numbers
            var oddNumbers = numbers.Where(num => num % 2 != 0);
            Console.WriteLine("Odd Numbers:");

            foreach (var num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
