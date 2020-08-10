using System;

namespace Algorithms.HackerRank
{
    public static class ArrayManipulation
    {
        public static long Execute(int n, int[][] queries)
        {
            var arr = new long[n];
            foreach (var query in queries)
            {
                var a = query[0] - 1;
                var b = query[1];
                var k = query[2];

                arr[a] += k;
                if (b < n)
                    arr[b] -= k;
            }

            long sum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                arr[i] = sum;
            }

            var max = long.MinValue;
            for (var i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
            }
            return max;
        }
    }
}
