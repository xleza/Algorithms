using System;

namespace Algorithms
{
    public static class MaxProfit
    {
        public static int Execute(int[] arr)
        {
            var result = 0;

            if (arr.Length == 0)
                return result;

            var aux = new int[arr.Length];

            var max = int.MinValue;
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                max = Math.Max(arr[i], max);
                aux[i] = max;
            }

            for (var i = 0; i < arr.Length; i++)
            {
                result = Math.Max(aux[i] - arr[i], result);
            }

            return result;
        }
    }
}
