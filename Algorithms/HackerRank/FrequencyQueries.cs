using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class FrequencyQueries
    {
        public static List<int> Execute(IEnumerable<List<int>> queries)
        {
            var elementFreq = new Dictionary<int, int>();
            var freqLookUp = new Dictionary<int, int>();
            var outputOfType3 = new List<int>();
            foreach (var query in queries)
            {
                var operation = query[0];
                var value = query[1];

                if (operation == 1)
                    IncreaseElementFreq(value, elementFreq, freqLookUp);

                else if (operation == 2 && elementFreq.ContainsKey(value) && elementFreq[value] > 0)
                    DecreaseElementFreq(value, elementFreq, freqLookUp);

                else if (operation == 3)
                {
                    if (!freqLookUp.ContainsKey(value) || freqLookUp[value] == 0)
                    {
                        outputOfType3.Add(0);
                    }
                    else
                    {
                        outputOfType3.Add(1);
                    }
                }
            }
            return outputOfType3;
        }

        private static void IncreaseElementFreq(int element, IDictionary<int, int> elementsFreq, IDictionary<int, int> freqLookUp)
        {
            if (!elementsFreq.ContainsKey(element))
                elementsFreq.Add(element, 0);

            var oldFreq = elementsFreq[element];
            var newFreq = oldFreq + 1;

            if (freqLookUp.ContainsKey(oldFreq))
                freqLookUp[oldFreq]--;

            elementsFreq[element] = newFreq;

            if (!freqLookUp.ContainsKey(newFreq))
                freqLookUp.Add(newFreq, 0);

            freqLookUp[newFreq]++;
        }

        private static void DecreaseElementFreq(int element, IDictionary<int, int> elementsFreq, IDictionary<int, int> freqLookUp)
        {
            freqLookUp[elementsFreq[element]]--;
            elementsFreq[element]--;

            if (elementsFreq[element] == 0)
                return;

            if (!freqLookUp.ContainsKey(elementsFreq[element]))
                freqLookUp.Add(elementsFreq[element], 0);

            freqLookUp[elementsFreq[element]]++;
        }
    }
}
