using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HackerRank
{
    public static class HourglassSum
    {
        public static int Execute(int[][] arr)
        {
            var maxSum = int.MinValue;
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    maxSum = Math.Max(
                        maxSum,
                        arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                  + arr[i + 1][j + 1] +
                        arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]
                    );
                }
            }

            return maxSum;
        }
    }
}
