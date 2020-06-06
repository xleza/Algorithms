using System;

namespace Algorithms
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array, Func<T, T, bool> compare)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var minIndex = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (compare(array[minIndex], array[j]))
                        minIndex = j;
                }

                var temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}
