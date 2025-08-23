using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp1
{
    internal class Linq3
    {
        public Linq3()
        {
            Console.WriteLine("LINQ Example 3:");
            String peapleData = "A";

            var changePeaple = peapleData.Select(x => x + "さんは");
            foreach (var person in changePeaple)
                {
                Console.WriteLine(person);
            }
        }
    }
}
