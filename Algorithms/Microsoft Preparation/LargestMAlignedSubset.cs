using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class LargestMAlignedSubset
    {
        public static int Execute(int[] arr, int m)
        {
            var numbersWithSameReminder = new Dictionary<int, List<int>>();
            for (var i = 0; i < arr.Length; i++)
            {
                var remainder = arr[i] % m;
                if (remainder < 0)
                    remainder += m;

                if (!numbersWithSameReminder.ContainsKey(remainder))
                    numbersWithSameReminder[remainder] = new List<int>();

                numbersWithSameReminder[remainder].Add(arr[i]);
            }

            var maxAlignedCount = 0;
            foreach (var item in numbersWithSameReminder)
            {
                maxAlignedCount = Math.Max(maxAlignedCount, item.Value.Count);
            }

            return maxAlignedCount;
        }
    }
}
