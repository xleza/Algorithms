using System;

namespace Algorithms
{
    public static class MaxNetworkRank
    {
        public static int Execute(int[] a, int[] b, int n)
        {
            var max = 0;
            var cityRoadsCount = new int[n + 1];

            for (var i = 0; i < n; i++)
            {
                cityRoadsCount[a[i]]++;
                cityRoadsCount[b[i]]++;
            }

            for (var i = 0; i < n; i++)
            {
                max = Math.Max(max, cityRoadsCount[a[i]] + cityRoadsCount[b[i]] - 1);
            }
            return max;
        }
    }
}
