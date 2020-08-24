using System;
using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class LargestRectangle
    {
        public static long Execute(int[] h)
        {
            var track = new Stack<int>();
            long maxArea = 0;
            var i = 0;
            for (; i < h.Length; i++)
            {
                if (track.Count == 0)
                {
                    track.Push(i);
                    continue;
                }

                if (h[track.Peek()] <= h[i])
                {
                    track.Push(i);
                    continue;
                }

                while (track.Count > 0 && h[track.Peek()] > h[i])
                    maxArea = GetMaxArea(maxArea, track, h, i);

                i--;
            }

            while (track.Count != 0)
                maxArea = GetMaxArea(maxArea, track, h, i);


            return maxArea;
        }

        private static long GetMaxArea(long currentArea, Stack<int> track, IReadOnlyList<int> heights, int currentBuildingIndex)
        {
            var top = track.Pop();
            return track.Count == 0 ?
                Math.Max(currentArea, heights[top] * currentBuildingIndex) :
                Math.Max(currentArea, heights[top] * (currentBuildingIndex - track.Peek() - 1));
        }
    }
}
