using System.Collections.Generic;

namespace Algorithms
{
    public sealed class BirthdayChocolate
    {
        public static int Execute(List<int> s, int d, int m)
        {
            var sum = 0;
            for (var i = 0; i < m; i++)
            {
                sum += s[i];
            }

            var result = sum == d ? 1 : 0;

            if (s.Count == m)
                return result;

            for (var i = 0; i + m < s.Count; i++)
            {
                sum = sum - s[i] + s[m + i];
                if (sum == d)
                    result++;
            }

            return result;
        }
    }
}
