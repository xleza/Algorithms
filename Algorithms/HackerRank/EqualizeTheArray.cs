using System;
using System.Linq;

namespace Algorithms.HackerRank
{
    public static class EqualizeTheArray
    {
        public static int Execute(int[] arr)
        {
            var list = arr.GroupBy(x => x).Select(x => x.Count());
            var max = int.MinValue;
            foreach (var item in list)
            {
                max = Math.Max(item, max);
            }
            return arr.Length - max;
        }
    }
}
