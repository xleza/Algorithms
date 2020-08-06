using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class PickingNumbers
    {
        public static int Execute(List<int> a)
        {
            var numberCountLookUp = new Dictionary<int, int>();
            foreach (var item in a)
            {
                if (!numberCountLookUp.ContainsKey(item))
                    numberCountLookUp.Add(item, 0);

                numberCountLookUp[item]++;
            }

            var max = 0;
            foreach (var t in a)
            {
                var sum = numberCountLookUp[t];
                if (numberCountLookUp.ContainsKey(t - 1))
                    sum += numberCountLookUp[t - 1];

                max = Math.Max(sum, max);
            }

            return max;
        }
    }
}
