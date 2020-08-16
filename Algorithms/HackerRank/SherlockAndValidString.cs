using System;
using System.Linq;

namespace Algorithms.HackerRank
{
    public static class SherlockAndValidString
    {
        public static bool Execute(string s)
        {
            var frequencies = new int[26];
            foreach (var item in s)
            {
                frequencies[item - 'a']++;
            }

            var mostFrequentFrequency = frequencies.Where(x => x != 0).GroupBy(x => x).OrderBy(x => x.Count()).Last().Key;
            var canUseDeletion = true;

            for (var i = 0; i < frequencies.Length; i++)
            {
                if (frequencies[i] == mostFrequentFrequency || frequencies[i] == 0)
                    continue;

                if (!canUseDeletion)
                    return false;

                if (Math.Abs(frequencies[i] - mostFrequentFrequency) == 1 || frequencies[i] == 1)
                    canUseDeletion = false;
            }

            return true;
        }
    }
}
