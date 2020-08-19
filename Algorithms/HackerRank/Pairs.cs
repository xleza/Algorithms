using System.Linq;

namespace Algorithms.HackerRank
{
    public sealed class Pairs
    {
        static int Execute(int k, int[] arr)
        {
            var set = arr.ToHashSet();
            var count = 0;
            foreach (var item in arr)
            {
                if (set.Contains(item - k))
                    count++;
            }
            return count;
        }
    }
}
