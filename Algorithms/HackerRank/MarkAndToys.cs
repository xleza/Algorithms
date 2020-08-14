using System;

namespace Algorithms.HackerRank
{
    public static class MarkAndToys
    {
        public static int Execute(int[] prices, int k)
        {
            Array.Sort(prices);
            var numberOfToys = 0;
            var spent = 0;

            foreach (var price in prices)
            {
                spent += price;
                if (spent > k)
                    break;
                numberOfToys++;
            }
            return numberOfToys;
        }
    }
}
