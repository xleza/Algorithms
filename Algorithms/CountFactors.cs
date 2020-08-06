using System;

namespace Algorithms
{
    public sealed class CountFactors
    {
        public static int Execute(int n)
        {
            var result = 0;

            for (var i = 1; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i != 0)
                    continue;

                result++;

                if (n / i != i)
                    result++;
            }

            return result;
        }
    }
}
