using System.Collections.Generic;

namespace Algorithms
{
    public static class Permutation
    {
        public static List<List<int>> Execute(List<int> array)
        {
            var result = new List<List<int>>();
            NextPermutation(array, 0, result);

            return result;
        }

        private static void NextPermutation(List<int> items, int currentIndex, List<List<int>> permutations)
        {
            if (currentIndex == items.Count - 1)
            {
                permutations.Add(new List<int>(items));
                return;
            }

            for (var i = currentIndex; i < items.Count; i++)
            {
                Swap(currentIndex, i, items);
                NextPermutation(items, currentIndex + 1, permutations);
                Swap(i, currentIndex, items);
            }
        }

        private static void Swap(int source, int dest, List<int> items)
        {
            var temp = items[source];
            items[source] = items[dest];
            items[dest] = temp;
        }
    }
}
