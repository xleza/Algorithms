using System.Collections.Generic;

namespace Algorithms
{
    public static class MinAdjSwapsToGroupRedBalls
    {
        public static int Execute(string str)
        {
            var redPositions = GetRedPositions(str);
            var middle = redPositions.Count / 2;

            var minSwaps = 0;
            for (var i = middle + 1; i < redPositions.Count; i++)
            {
                var padding = i - middle;
                minSwaps += redPositions[i] - redPositions[middle] - padding;
            }

            for (var i = middle - 1; i >= 0; i--)
            {
                var padding = middle - i;
                minSwaps += redPositions[middle] - redPositions[i] - padding;
            }

            return minSwaps;
        }

        private static List<int> GetRedPositions(string str)
        {
            var positions = new List<int>();
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == 'R')
                    positions.Add(i);
            }

            return positions;
        }
    }
}
