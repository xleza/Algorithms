namespace Algorithms
{
    public static class LongestSubstringWithout3ContiguousOccurrencesOfLetter
    {
        public static string Execute(string str)
        {
            var result = "";

            for (var i = 0; i < str.Length; i++)
            {
                var acc = "";
                var aCount = 0;
                var bCount = 0;
                for (var j = i; j < str.Length; j++)
                {
                    if (str[j] == 'a')
                    {
                        aCount++;
                        bCount = 0;
                    }
                    else
                    {
                        bCount++;
                        aCount = 0;
                    }

                    if (aCount > 2 || bCount > 2)
                        break;

                    acc += str[j];
                }

                if (result.Length < acc.Length)
                    result = acc;
            }

            return result;
        }

        public static string Execute1(string str)
        {
            var result = "";
            var left = 0;
            var right = 0;
            var minLeft = 0;
            var maxRight = 0;
            var aCount = 0;
            var bCount = 0;

            while (right < str.Length)
            {
                if (str[right] == 'a')
                {
                    aCount++;
                    bCount = 0;
                }
                else
                {
                    bCount++;
                    aCount = 0;
                }

                if (aCount <= 2 && bCount <= 2)
                {
                    right++;
                }
                else
                {
                    left = right;
                    aCount = 0;
                    bCount = 0;
                }

                if (right - left > maxRight - minLeft)
                {
                    minLeft = left;
                    maxRight = right;
                }
            }

            for (var i = minLeft; i < maxRight; i++)
            {
                result += str[i];
            }

            return result;
        }
    }
}
