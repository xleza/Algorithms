using System;

namespace Algorithms
{
    public static class BinaryMaxGap
    {
        public static int GetResult(int n)
        {
            var binary = Convert.ToString(n, 2);
            var maxGap = 0;
            var count = 0;

            foreach (var c in binary)
            {
                if (c == '1')
                {

                    maxGap = Math.Max(count, maxGap);
                    count = 0;
                    continue;
                }
                count++;
            }

            return maxGap;
        }
    }
}
