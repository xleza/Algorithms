using System;

namespace Algorithms
{
    public static class MergeSort<T>
    {
        public static void Sort(T[] arr, Func<T, T, bool> compare)
        {
            var aux = new T[arr.Length];
            Sort(arr, aux, compare, 0, arr.Length - 1);
        }

        private static void Sort(T[] arr, T[] aux, Func<T, T, bool> compare, int start, int end)
        {
            if (start >= end)
                return;

            var middle = (start + end) / 2;

            Sort(arr, aux, compare, start, middle);
            Sort(arr, aux, compare, middle + 1, end);

            Merge(arr, aux, compare, start, middle, end);
        }

        private static void Merge(T[] arr, T[] aux, Func<T, T, bool> compare, int start, int mid, int end)
        {
            for (var k = start; k <= end; k++)
            {
                aux[k] = arr[k];
            }

            var i = start;
            var j = mid + 1;

            for (var k = start; k <= end; k++)
            {
                if (i > mid)
                    arr[k] = aux[j++];
                else if (j > end)
                    arr[k] = aux[i++];
                else if (!compare(aux[i], aux[j]))
                    arr[k] = aux[i++];
                else
                    arr[k] = aux[j++];
            }
        }
    }
}
