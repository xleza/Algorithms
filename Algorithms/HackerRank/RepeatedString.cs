using System.Linq;

namespace Algorithms.HackerRank
{
    public static class RepeatedString
    {
        public static long Execute(string s, long n)
        {
            var countOfAInString = s.Count(x => x == 'a');
            var wholeStringOccurrences = n / s.Length;
            var partialStringOccurrences = n % s.Length;
            var firstLetterOccurrences = wholeStringOccurrences * countOfAInString;

            for (var i = 0; i < partialStringOccurrences; i++)
            {
                if (s[i] == 'a')
                    firstLetterOccurrences++;
            }
            return firstLetterOccurrences;
        }
    }
}
