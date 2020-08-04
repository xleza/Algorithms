using System;

namespace Algorithms
{
    public sealed class MaxSliceSum
    {
        public static int Execute(int[] arr)
        {
            var sumEnding = 0;
            var maxSum = int.MinValue;

            foreach (var item in arr)
            {
                sumEnding = Math.Max(item, sumEnding + item);
                maxSum = Math.Max(sumEnding, maxSum);
            }

            return maxSum;
        }
    }
}
