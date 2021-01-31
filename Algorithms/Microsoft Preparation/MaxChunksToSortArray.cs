using System;

namespace Algorithms
{
    public static class MaxChunksToSortArray
    {
        public static int Execute(int[] arr)
        {
            var sortedArray = new int[arr.Length];
            Array.Copy(arr, sortedArray, arr.Length);
            Array.Sort(sortedArray);

            var chunks = 0;
            var currentSum = 0;
            var sortedSum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                currentSum += arr[i];
                sortedSum += sortedArray[i];

                if (currentSum == sortedSum)
                {
                    chunks++;
                }
            }

            return chunks;
        }
    }
}
