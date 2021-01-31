using System.Linq;

namespace Algorithms
{
    public static class MinimumWindowSubstring
    {
        public static string Execute(string s, string t)
        {
            var charLookUp = t.ToHashSet();
            var minWindow = "";
            for (var i = 0; i < s.Length; i++)
            {
                if (!charLookUp.Contains(s[i]))
                    continue;

                var charsToVisit = t.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                var window = "";
                for (var j = i; j < s.Length; j++)
                {
                    window += s[j];
                    if (charsToVisit.ContainsKey(s[j]))
                    {
                        charsToVisit[s[j]]--;
                        if (charsToVisit[s[j]] == 0)
                            charsToVisit.Remove(s[j]);
                    }

                    if (charsToVisit.Count == 0)
                        break;
                }
                if (charsToVisit.Count == 0)
                {
                    if (minWindow == "" || minWindow.Length > window.Length)
                    {
                        minWindow = window;
                    }
                }
            }
            return minWindow;
        }

        public static string Execute1(string s, string t)
        {
            var window = t.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            var passedWindowElementsCount = 0;
            var minWindow = s.GroupBy(x => x).ToDictionary(x => x.Key, _ => 0);
            var windowStart = -1;
            var windowEnd = -1;
            var left = 0;
            var right = 0;

            while (right < s.Length)
            {
                if (passedWindowElementsCount != t.Length)
                {
                    if (window.ContainsKey(s[right]) && window[s[right]] > minWindow[s[right]])
                        passedWindowElementsCount++;

                    minWindow[s[right]]++;
                    if (passedWindowElementsCount != t.Length)
                        right++;
                }
                else
                {
                    if (windowEnd == -1 || right - left < windowEnd - windowStart)
                    {
                        windowStart = left;
                        windowEnd = right;
                    }

                    if (windowEnd - windowStart + 1 == t.Length)
                    {
                        break;
                    }

                    minWindow[s[left]]--;

                    if (window.ContainsKey(s[left]) && window[s[left]] > minWindow[s[left]])
                    {
                        passedWindowElementsCount--;
                        right++;
                    }

                    left++;
                }

            }

            var result = "";

            if (windowStart == -1)
                return result;

            for (var i = windowStart; i <= windowEnd; i++)
            {
                result += s[i];
            }

            return result;
        }
    }
}
