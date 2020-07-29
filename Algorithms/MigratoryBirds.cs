using System.Collections.Generic;

namespace Algorithms
{
    public sealed class MigratoryBirds
    {
        public static int GetResult(IEnumerable<int> birds)
        {
            var maxKind = int.MaxValue;
            var maxKindValue = 0;
            var kindsLookUp = new Dictionary<int, int>();

            foreach (var bird in birds)
            {
                if (!kindsLookUp.ContainsKey(bird))
                    kindsLookUp.Add(bird, 0);
                kindsLookUp[bird]++;

                if (kindsLookUp[bird] > maxKindValue)
                {
                    maxKind = bird;
                    maxKindValue = kindsLookUp[bird];
                }
                else if (kindsLookUp[bird] == maxKindValue && maxKind > bird)
                    maxKind = bird;
            }

            return maxKind;
        }
    }
}
