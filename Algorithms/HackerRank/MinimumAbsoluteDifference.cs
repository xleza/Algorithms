using System;

namespace Algorithms.HackerRank
{
    public static class MinimumAbsoluteDifference
    {
        public static int Execute(int[] arr)
        {
            Array.Sort(arr);
            var min = int.MaxValue;
            for (var i = 1; i < arr.Length; i++)
            {
                min = Math.Min(min, Math.Abs(arr[i] - arr[i - 1]));
            }
            return min;
        }
    }
}
