using System;
using System.Linq;

namespace Algorithms
{
    public sealed class Dominator
    {
        public int Execute(int[] arr)
        {
            var element = arr.GroupBy(x => x)
                .FirstOrDefault(x => x.Count() > arr.Length / 2);
            if (element == null)
                return -1;

            return Array.IndexOf(arr, element.Key);
        }
    }
}
