using System;
using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class SherlockAndAnagrams
    {
        public static int Execute(string s)
        {
            var substringsLookUp = new Dictionary<string, int>();
            for (var i = 0; i < s.Length; i++)
            {
                var str = "";
                for (var j = i; j < s.Length; j++)
                {
                    str += s[j];
                    var arrayToSort = str.ToCharArray();
                    Array.Sort(arrayToSort);
                    var sortedString = new string(arrayToSort);
                    if (!substringsLookUp.ContainsKey(sortedString))
                        substringsLookUp.Add(sortedString, 0);

                    substringsLookUp[sortedString]++;
                }
            }

            var anagramsCount = 0;

            foreach (var item in substringsLookUp)
            {
                anagramsCount += item.Value * (item.Value - 1) / 2;
            }
            return anagramsCount;
        }
    }
}
