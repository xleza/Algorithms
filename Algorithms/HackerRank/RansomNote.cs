using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HackerRank
{
    public static class RansomNote
    {
        public static bool Execute(string[] magazine, string[] note)
        {
            var magazineWordsLookUp = new Dictionary<string, int>();
            foreach (var item in magazine)
            {
                if (!magazineWordsLookUp.ContainsKey(item))
                    magazineWordsLookUp.Add(item, 0);

                magazineWordsLookUp[item]++;
            }

            foreach (var item in note)
            {
                if (!magazineWordsLookUp.ContainsKey(item) || magazineWordsLookUp[item] == 0)
                    return false;
                magazineWordsLookUp[item]--;
            }
            return true;
        }
    }
}
