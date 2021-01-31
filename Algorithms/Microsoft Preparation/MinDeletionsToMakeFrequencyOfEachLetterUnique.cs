using System.Linq;

namespace Algorithms
{
    public static class MinDeletionsToMakeFrequencyOfEachLetterUnique
    {
        public static int Execute(string str)
        {
            var deletions = 0;
            var freq = str.GroupBy(x => x)
                .Select(x => x.Count())
                .OrderBy(x => x)
                .ToList(); // Get Sorted Frequencies

            for (var i = 0; i < freq.Count - 1; i++)
            {
                if (freq[i] == 0) // we should skip 0, because it indicates to the removed elements
                    continue;

                if (freq[i] == freq[i + 1]) // if we have same frequencies, we should delete one of them
                {
                    freq[i]--; // decrement of the element
                    deletions++;
                    i = -1; // start next iteration from the beginning
                }
            }

            return deletions;
        }


    }
}
