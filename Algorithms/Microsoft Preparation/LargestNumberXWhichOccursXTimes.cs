using System;
using System.Linq;

namespace Algorithms
{
    public static class LargestNumberXWhichOccursXTimes
    {
        public static int Execute(int[] arr)
        {
            var frequencies = arr.GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());

            var largestNumbers = 0;

            foreach (var freq in frequencies)
            {
                if (freq.Key != freq.Value)
                    continue;

                largestNumbers = Math.Max(largestNumbers, freq.Value);
            }

            return largestNumbers;
        }
    }
}
