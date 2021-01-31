using System;
using System.Collections.Generic;

namespace Algorithms
{
    public sealed class LongestSubstringWithoutRepeatingCharacters
    {
        public static int Execute(string s)
        {
            if (s.Length == 1)
                return 1;

            var left = 0;
            var right = 0;

            var visited = new HashSet<char>();
            var maxDistance = 0;

            while (right < s.Length)
            {
                if (!visited.Contains(s[right]))
                {
                    visited.Add(s[right]);
                    maxDistance = Math.Max(maxDistance, visited.Count);
                    right++;
                }
                else
                {
                    visited.Remove(s[left]);
                    left++;
                }
            }

            return maxDistance;
        }
    }
}
