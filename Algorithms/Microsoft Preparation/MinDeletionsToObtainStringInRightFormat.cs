using System;

namespace Algorithms
{
    public static class MinDeletionsToObtainStringInRightFormat
    {
        public static int Execute(string s)
        {
            var seenB = false;
            var followingElementsCount = 1;
            var aToDelete = 0;
            var bToDelete = 0;
            char? prev = null;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    if (seenB)
                        aToDelete++;

                    if (prev == 'B')
                        bToDelete += followingElementsCount;
                }
                else
                {
                    seenB = true;
                }

                if (s[i] == prev)
                    followingElementsCount++;
                else
                    followingElementsCount = 1;

                prev = s[i];
            }

            return Math.Min(aToDelete, bToDelete);
        }
    }
}
