using System.Linq;

namespace Algorithms.HackerRank
{
    public static class TripleSum
    {
        static long Execute(int[] a, int[] b, int[] c)
        {
            long count = 0;
            var sortedA = a.Distinct().OrderBy(x => x).ToArray();
            var sortedB = b.Distinct().ToArray();
            var sortedC = c.Distinct().OrderBy(x => x).ToArray();

            foreach (var item in sortedB)
            {
                long lessElementsCountFromA = GetGreaterElementCount(sortedA, item);
                if (lessElementsCountFromA == -1)
                    continue;

                long lessElementsCountFromC = GetGreaterElementCount(sortedC, item);
                if (lessElementsCountFromC == -1)
                    continue;

                count += lessElementsCountFromA * lessElementsCountFromC;
            }

            return count;
        }

        static int GetGreaterElementCount(int[] arr, int k, int? startIndex = null, int? endIndex = null)
        {
            if (!startIndex.HasValue)
                startIndex = 0;

            if (!endIndex.HasValue)
                endIndex = arr.Length - 1;

            if (startIndex > endIndex)
                return -1;

            var middle = (startIndex.Value + endIndex.Value) / 2;

            if (arr[middle] == k)
                return middle + 1;

            if (middle == arr.Length - 1)
                return middle + 1;


            if (k < arr[middle])
            {
                if (middle == 0)
                    return 0;

                return GetGreaterElementCount(arr, k, startIndex, middle - 1);
            }

            if (k < arr[middle + 1])
                return middle + 1;

            return GetGreaterElementCount(arr, k, middle + 1, endIndex);
        }
    }
}
