using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp1
{
    internal class Linq2
    {
        public Linq2()
        {
            Console.WriteLine("LINQ Example 2:");
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry", "Fig", "Grape" };

            // Using LINQ to filter fruits that start with the letter 'C'
            var fruitsStartingWithC = from fruit in fruits
                                      where fruit.StartsWith("C")
                                      select fruit;
            Console.WriteLine("Fruits starting with 'C':");
            foreach (var fruit in fruitsStartingWithC)
            {
                Console.WriteLine(fruit);
            }

            // Using LINQ method syntax to filter fruits with length greater than 4
            var longFruits = fruits.Where(fruit => fruit.Length > 4);
            Console.WriteLine("Fruits with length greater than 4:");
            foreach (var fruit in longFruits)
            {
                Console.WriteLine(fruit);
            }

            // Original 
            Console.WriteLine("アレン");
            List<int> listInt = new List<int> { 10, 20, 50};
            listInt.Add(100);
            foreach (int n in listInt)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("20以外");
            var jogai = listInt.Where(n => n != 20);
            foreach (int n in jogai)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("50以外");
            var jogai2 = listInt.Where(n => n != 50);
            foreach (int n in jogai2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("50以外");
            var jogai3 = from n in listInt
                         where n != 50
                         select n;
            foreach (int n in jogai3)
                {
                Console.WriteLine(n);
            }
        }
    }
}
