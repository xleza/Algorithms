using System;

namespace Algorithms
{
    public sealed class DetectCapitalUse
    {
        public static bool Execute(string word)
        {
            var firstIsCapital = char.IsUpper(word[0]);
            var allCapitals = firstIsCapital;
            var allNotCapitals = !firstIsCapital;

            for (var i = 1; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    firstIsCapital = false;
                    allNotCapitals = false;
                }
                else
                {
                    allCapitals = false;
                }
            }

            return firstIsCapital || allNotCapitals || allCapitals;
        }
    }
}
