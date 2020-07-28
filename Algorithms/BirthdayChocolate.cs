using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public sealed class BirthdayChocolate
    {
        public static int Execute(List<int> s, int d, int m)
        {
            if (s.Count == m)
                return s.Sum() == d ? 1 : 0;

            var result = 0;
            for (var i = 0; i < s.Count - m + 1; i++)
            {
                var sum = s[i];
                for (var j = 0; j < m - 1; j++)
                {
                    sum += s[i + 1 + j];
                }
                if (sum == d)
                    result++;
            }

            return result;
        }
    }
}
