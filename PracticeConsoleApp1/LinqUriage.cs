using System;
using System.Collections.Generic;
using System.Linq;

class Sale
{
    public string Region { get; set; }
    public decimal Amount { get; set; }
}

internal class LincUriage
{
   public LincUriage()
    {
        // サンプルデータ
        var salesList = new List<Sale>
        {
            new Sale { Region = "Tokyo", Amount = 120000 },
            new Sale { Region = "Osaka", Amount = 95000 },
            new Sale { Region = "Tokyo", Amount = 80000 },
            new Sale { Region = "Nagoya", Amount = 67000 },
            new Sale { Region = "Osaka", Amount = 103000 },
            new Sale { Region = "Nagoya", Amount = 45000 }
        };

        // LINQで地域ごとの売上合計を集計
        var totalByRegion = salesList
            .GroupBy(s => s.Region)
            .ToDictionary(g => g.Key, g => g.Max(s => s.Amount));

        // 結果を表示
        foreach (var kvp in totalByRegion)
        {
            Console.WriteLine($"{kvp.Key}: ¥{kvp.Value:N0}");
        }
    }
}
