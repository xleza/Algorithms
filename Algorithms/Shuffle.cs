using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class Shuffle
    {
        private static void GetResult<T>(IList<T> collection)
        {
            var random = new Random();
            for (var i = 0; i < collection.Count; i++)
            {
                var r = random.Next(0, i + 1);
                var temp = collection[i];
                collection[i] = collection[r];
                collection[r] = temp;
            }
        }
    }
}
