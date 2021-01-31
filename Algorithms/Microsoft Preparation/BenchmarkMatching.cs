using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class BenchmarkMatching
    {
        public static List<string> Execute(string str)
        {
            var portfolioShares = new Dictionary<(string company, string asset), int>();
            var benchmarkShares = new Dictionary<(string company, string asset), int>();

            var info = str.Split(':');

            foreach (var assets in info[0].Split('|'))
            {
                var assetInfo = assets.Split(',');
                portfolioShares.Add((assetInfo[0], assetInfo[1]), int.Parse(assetInfo[2]));
            }


            foreach (var assets in info[1].Split('|'))
            {
                var assetInfo = assets.Split(',');
                benchmarkShares.Add((assetInfo[0], assetInfo[1]), int.Parse(assetInfo[2]));
            }

            var transactions = new List<Transaction>();

            foreach (var item in portfolioShares)
            {
                if (!benchmarkShares.ContainsKey(item.Key))
                {
                    transactions.Add(new Transaction("SELL", item.Key.company, item.Key.asset, item.Value));
                    continue;
                }

                var benchmarkShare = benchmarkShares[item.Key];
                if (item.Value > benchmarkShare)
                {
                    transactions.Add(new Transaction("SELL", item.Key.company, item.Key.asset, item.Value - benchmarkShare));
                }
                else if (item.Value < benchmarkShare)
                {
                    transactions.Add(new Transaction("BUY", item.Key.company, item.Key.asset, benchmarkShare - item.Value));
                }
            }

            foreach (var item in benchmarkShares)
            {
                if (!portfolioShares.ContainsKey(item.Key))
                    transactions.Add(new Transaction("BUY", item.Key.company, item.Key.asset, item.Value));
            }

            return transactions.OrderBy(x => x.Company)
                .ThenBy(x => x.AssetType)
                .Select(x => x.ToString())
                .ToList();
        }

        private static string GetTransaction(string type, string company, string assetType, int shares)
        {
            return $"{type},{company},{assetType},{shares}";
        }

        private class Transaction
        {
            public string Name { get; set; }
            public string Company { get; set; }
            public string AssetType { get; set; }
            public int Shares { get; set; }

            public Transaction(string name, string company, string assetType, int shares)
            {
                Name = name;
                Company = company;
                AssetType = assetType;
                Shares = shares;
            }

            public override string ToString()
            {
                return $"{Name},{Company},{AssetType},{Shares}";
            }
        }
    }
}
