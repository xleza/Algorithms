using System;

namespace Algorithms
{
    public static class WidestPathWithoutTrees
    {
        public static int Execute(int[] x, int[] y)
        {
            Array.Sort(x);
            var maxWidth = 0;
            for (var i = 0; i < x.Length - 1; i++)
            {
                maxWidth = Math.Max(maxWidth, x[i + 1] - x[i]);
            }

            return maxWidth;
        }
    }
}
