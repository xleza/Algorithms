using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class LargestSubstringBetweenTwoEqualCharacters
    {
        public static int Execute(string s)
        {
            var lettersIndicies = new Dictionary<char, List<int>>();
            for (var i = 0; i < s.Length; i++)
            {
                if (!lettersIndicies.ContainsKey(s[i]))
                    lettersIndicies.Add(s[i], new List<int>());
                var indicies = lettersIndicies[s[i]];
                if (indicies.Count < 2)
                {
                    indicies.Add(i);
                }
                else
                {
                    indicies[1] = i;
                }
            }
            var result = -1;
            foreach (var letterIndicies in lettersIndicies.Values)
            {
                if (letterIndicies.Count < 2)
                    continue;

                result = Math.Max(result, letterIndicies[1] - letterIndicies[0] - 1);
            }

            return result;
        }
    }
}
