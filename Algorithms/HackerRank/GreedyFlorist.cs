using System;

namespace Algorithms.HackerRank
{
    public static class GreedyFlorist
    {
        public static int Execute(int n, int k, int[] c)
        {
            Array.Sort(c);
            var totalPrice = 0;
            for (var i = n - 1; i >= 0; i--)
            {
                totalPrice += ((n - 1 - i) / k + 1) * c[i];
            }
            return totalPrice;
        }

    }
}
