using System;
using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class LilysHomework
    {
        public static int Execute(int[] arr)
        {
            var aux = new int[arr.Length];
            var arrToDescSorting = new int[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                aux[i] = arr[i];
                arrToDescSorting[i] = arr[i];
            }

            Array.Sort(aux);

            var indexLookUp = new Dictionary<int, int>();
            for (var i = 0; i < aux.Length; i++)
            {
                indexLookUp.Add(aux[i], i);
            }


            return Math.Min(Sort(arr, indexLookUp, true), Sort(arrToDescSorting, indexLookUp, false));
        }

        private static int Sort(IList<int> arr, IReadOnlyDictionary<int, int> indexLookUp, bool asc)
        {
            var swaps = 0;

            for (var i = 0; i < arr.Count; i++)
            {
                var correctIndex = asc ? indexLookUp[arr[i]] : arr.Count - 1 - indexLookUp[arr[i]];

                var inOrder = i == correctIndex;
                if (inOrder)
                    continue;

                var temp = arr[correctIndex];
                arr[correctIndex] = arr[i];
                arr[i] = temp;
                swaps++;
                i--;
            }

            return swaps;
        }
    }
}
