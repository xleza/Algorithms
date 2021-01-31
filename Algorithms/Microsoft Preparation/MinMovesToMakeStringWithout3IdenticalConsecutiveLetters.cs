using System;

namespace Algorithms
{
    public static class MinMovesToMakeStringWithout3IdenticalConsecutiveLetters
    {
        public static int Execute(string str)
        {
            var next = 0;
            var minMoves = 0;

            for (var i = 0; i < str.Length; i++)
            {
                var consecutiveLettersNumber = 0;
                while (str[i] == str[next] && next < str.Length - 1)
                {
                    consecutiveLettersNumber++;
                    next++;
                }

                minMoves += consecutiveLettersNumber / 3;
                i = Math.Max(i, next);
            }


            return minMoves;
        }
    }
}
