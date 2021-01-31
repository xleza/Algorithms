using System.Collections.Generic;

namespace Algorithms
{
    public static class NumberOfFractions
    {
        public static int Execute(int[] numerators, int[] denumerators)
        {
            var freq = new Dictionary<(int numerator, int denumerator), int>();
            var number = 0;

            for (var i = 0; i < numerators.Length; i++)
            {
                var gcd = Gcd(numerators[i], denumerators[i]);
                var numerator = numerators[i] / gcd;
                var denumerator = denumerators[i] / gcd;

                var complement = (denumerator - numerator, denumerator);
                if (freq.ContainsKey(complement) && freq[complement] > 0)
                    number += freq[complement];

                var key = (numerator, denumerator);
                if (!freq.ContainsKey(key))
                    freq.Add(key, 0);
                freq[key]++;
            }

            return number;
        }

        private static int Gcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                var temp = a;
                a = b;
                b = temp % b;
            }

            return a != 0 ? a : b;
        }
    }
}
