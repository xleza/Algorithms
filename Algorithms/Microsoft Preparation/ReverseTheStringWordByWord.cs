using System.Linq;

namespace Algorithms
{
    public sealed class ReverseTheStringWordByWord
    {
        public static string Execute(string s)
        {
            var result = "";
            var currentWord = "";
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (currentWord == "")
                        continue;

                    result = ConcatWithSpace(result, currentWord);
                    currentWord = "";
                    continue;
                }
                currentWord += s[i];
            }

            if (currentWord != "")
            {
                result = ConcatWithSpace(result, currentWord);
            }
            return result;
        }

        public static string Execute1(string s)
        {
            return string.Join(" ", s.Split(" ").Where(x => x != "").Reverse());

        }

        private static string ConcatWithSpace(string s1, string s2)
        {
            if (s1 != "")
                s1 = " " + s1;
            return s2 + s1;
        }
    }
}
