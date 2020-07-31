using System;

namespace Algorithms
{
    public static class NumberOfDiscIntersections
    {
        private static int GetResult(int[] arr)
        {
            var openEndPoints = new long[arr.Length];
            var closeEndPoints = new long[arr.Length];

            for (long i = 0; i < arr.Length; i++)
            {
                openEndPoints[i] = i - arr[i];
                closeEndPoints[i] = i + arr[i];
            }

            Array.Sort(openEndPoints);
            Array.Sort(closeEndPoints);

            var openEndPointIndex = 0;
            var closeEndPointIndex = 0;
            var openCircleCount = 0;
            var result = 0;

            while (openEndPointIndex <= arr.Length - 1)
            {
                if (openEndPoints[openEndPointIndex] <= closeEndPoints[closeEndPointIndex])
                {
                    result += openCircleCount;

                    if (result > 10000000)
                        return -1;

                    openCircleCount++;
                    openEndPointIndex++;
                }
                else
                {
                    openCircleCount--;
                    closeEndPointIndex++;
                }
            }

            return result;
        }
    }
}
