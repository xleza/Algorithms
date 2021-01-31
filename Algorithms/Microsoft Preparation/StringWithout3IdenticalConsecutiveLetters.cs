using System;

namespace Algorithms
{
    public static class StringWithout3IdenticalConsecutiveLetters
    {
        public static string Execute(string str)
        {
            var consecutiveNumbers = 1;
            var result = str[0].ToString();
            for (var i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == str[i])
                    consecutiveNumbers++;
                else
                    consecutiveNumbers = 1;

                if (consecutiveNumbers < 3)
                    result += str[i];
            }

            return result;
        }

        public static string Execute1(string str)
        {
            var result = str[0] + str[1].ToString();
            for (var i = 2; i < str.Length; i++)
            {
                if(str[i-2] == str[i-1] && str[i-1] == str[i])
                    continue;
                result += str[i];
            }
            return result;
        }
    }
}
