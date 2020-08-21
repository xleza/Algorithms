using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class BalancedSums
    {
        public static bool Execute(List<int> items)
        {
            var prefixSums = new int[items.Count];
            var sum = 0;
            for (var i = 0; i < items.Count; i++)
            {
                sum += items[i];
                prefixSums[i] = sum;
            }

            for (var i = 0; i < prefixSums.Length; i++)
            {
                if (prefixSums[i] - items[i] == prefixSums[prefixSums.Length - 1] - prefixSums[i])
                    return true;
            }

            return false;
        }
    }
}
