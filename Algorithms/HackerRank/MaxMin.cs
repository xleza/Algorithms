using System;

namespace Algorithms.HackerRank
{
    public static class MaxMin
    {
        public static int Execute(int k, int[] arr)
        {
            Array.Sort(arr);
            var min = int.MaxValue;

            for (var i = arr.Length - 1; i >= k - 1; i--)
            {
                min = Math.Min(min, arr[i] - arr[i - k + 1]);
            }

            return min;
        }
    }
}
