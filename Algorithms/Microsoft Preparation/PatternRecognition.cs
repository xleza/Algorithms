using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class PatternRecognition
    {
        public static string Execute(string str)
        {
            var split = str.Split(';');
            var pattern = split[0];
            var blobs = split[1].Split('|');

            var matches = new List<int>();

            foreach (var blob in blobs)
            {
                matches.Add(GetNumberOfMatches(blob, pattern));
            }

            matches.Add(matches.Sum());

            return string.Join('|', matches);
        }

        private static int GetNumberOfMatches(string blob, string pattern)
        {
            if (string.IsNullOrEmpty(blob) || string.IsNullOrEmpty(pattern))
                return 0;

            if (pattern.Length >= blob.Length)
                return pattern == blob ? 1 : 0;

            var matches = 0;
            for (var i = 0; i <= blob.Length - pattern.Length; i++)
            {
                var j = 0;
                for (; j < pattern.Length; j++)
                {
                    if (blob[i + j] != pattern[j])
                        break;
                }

                if (j == pattern.Length)
                    matches++;
            }

            return matches;
        }
    }
}
