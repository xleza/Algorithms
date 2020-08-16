using System;

namespace Algorithms.HackerRank
{
    public static class MakeAnagram
    {
        public static int Execute(string a, string b)
        {
            var frequencies = new int[26];
            foreach (var item in a)
                frequencies[item - 'a']++;

            foreach (var item in b)
                frequencies[item - 'a']--;

            var deletions = 0;
            foreach (var item in frequencies)
                deletions += Math.Abs(item);

            return deletions;
        }
    }
}
