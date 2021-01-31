using System;

namespace Algorithms
{
    public static class LongestSemiAlternatingSubstring
    {
        public static int Execute(string str)
        {
            var result = 1;
            var left = 0;
            var right = 1;
            var consecutiveNumbers = 1;

            while (right < str.Length)
            {
                if (str[right] == str[right - 1])
                    consecutiveNumbers++;
                else
                    consecutiveNumbers = 1;

                if (consecutiveNumbers < 3)
                    right++;
                else
                {
                    left = right - 1;
                    consecutiveNumbers = 1;
                }

                result = Math.Max(result, right - left);
            }


            return result;
        }
    }
}
