using System;

namespace Algorithms
{
    public static class MaxCounters
    {
        public static int[] GetResult(int n, int[] arr)
        {
            var lastMax = 0;
            var max = 0;
            var result = new int[n];

            foreach (var item in arr)
            {
                if (item == n + 1)
                {
                    lastMax = max;
                    continue;
                }

                var index = item - 1;
                result[index] = Math.Max(lastMax, result[index]);
                result[index]++;
                max = Math.Max(max, result[index]);
            }

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = Math.Max(lastMax, result[i]);
            }

            return result;
        }
    }
}
