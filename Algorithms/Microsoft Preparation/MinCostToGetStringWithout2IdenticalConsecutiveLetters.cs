using System;

namespace Algorithms
{
    public static class MinCostToGetStringWithout2IdenticalConsecutiveLetters
    {
        public static int Execute(string s, int[] costs)
        {
            var totalCost = 0;
            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    totalCost += Math.Min(costs[i], costs[i + 1]);
                    costs[i + 1] = Math.Max(costs[i], costs[i + 1]);
                }
            }

            return totalCost;
        }
    }
}
