using System;

namespace Algorithms
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] arr, Func<T, T, bool> compare)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i; j > 0; j--)
                {
                    if (compare(arr[j], arr[j - 1]))
                        break;

                    var temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}
