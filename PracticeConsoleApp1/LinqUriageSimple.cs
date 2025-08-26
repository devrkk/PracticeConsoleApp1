using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp1
{
    internal class LinqUriageSimple
    {
        public LinqUriageSimple()
        {
            // サンプルデータ
            var salesList = new List<Sale>
            {
                new Sale { Region = "Tokyo", Amount = 120000 },
                new Sale { Region = "Tokyo", Amount = 80000 },
                new Sale { Region = "Nagoya", Amount = 67000 },
                new Sale { Region = "Nagoya", Amount = 45000 }
            };

            var grouped = salesList.GroupBy(s => s.Region);
            //foreach(var group in grouped)
            //{
            //    Console.WriteLine(group.Key);
            //}

            var totalByRegion = new Dictionary<string, decimal>();

            foreach (var group in grouped)
            {
                var region = group.Key;
                var total = group.Sum(s => s.Amount);
                totalByRegion[region] = total;

                //Console.WriteLine(totalByRegion[region]);
            }

            var result = salesList
                        .GroupBy(s => s.Region)
                        .Select(g => new { Region = g.Key, Total = g.Sum(s => s.Amount) });

            foreach (var item in result)
            {
                //Console.WriteLine($"{item.Region}: {item.Total} 円");
            }





        }
    }
}
