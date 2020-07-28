using System;

namespace Algorithms
{
    public static class OddOccurrencesInArray
    {
        public static int GetResult(int[] arr)
        {
            Array.Sort(arr);
            for (var i = 0; i < arr.Length - 1; i += 2)
            {
                if (arr[i] != arr[i + 1])
                    return arr[i];
            }

            return arr[^1];
        }
    }
}
