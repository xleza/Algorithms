using System;

namespace Algorithms
{
    public static class MaxWidthOfVerticalArea
    {
        public static int Execute(int[][] points)
        {
            var xPoints = new int[points.Length];
            for (var i = 0; i < points.Length; i++)
            {
                xPoints[i] = points[i][0];
            }
            Array.Sort(xPoints);
            var maxWidth = 0;
            for (var i = 0; i < xPoints.Length - 1; i++)
            {
                maxWidth = Math.Max(maxWidth, xPoints[i + 1] - xPoints[i]);
            }
            return maxWidth;
        }
    }
}
