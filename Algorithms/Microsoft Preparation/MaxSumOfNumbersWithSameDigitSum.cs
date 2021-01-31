using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class MaxSumOfNumbersWithSameDigitSum
    {
        public static int Execute(int[] numbers)
        {
            var digitsSumLookUp = ConstructDigitSumLookUp(numbers);

            var maxSum = int.MinValue;
            foreach (var minMax in digitsSumLookUp.Values)
            {
                if (minMax.Min == -1)
                    continue;
                maxSum = Math.Max(maxSum, minMax.Max + minMax.Min);
            }
            return maxSum;
        }

        private static Dictionary<int, MinMax> ConstructDigitSumLookUp(IEnumerable<int> numbers)
        {
            var digitsSumLookUp = new Dictionary<int, MinMax>();

            foreach (var number in numbers)
            {
                var digitSum = GetDigitSum(number);
                if (!digitsSumLookUp.ContainsKey(digitSum))
                    digitsSumLookUp.Add(digitSum, new MinMax(-1, -1));

                var minMax = digitsSumLookUp[digitSum];

                if (minMax.Min > number)
                    continue;
                if (minMax.Max < number)
                    digitsSumLookUp[digitSum] = new MinMax(number, minMax.Max);
                else
                    digitsSumLookUp[digitSum] = new MinMax(minMax.Max, number);
            }

            return digitsSumLookUp;
        }

        private static int GetDigitSum(int number)
        {
            var sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }

    struct MinMax
    {
        public int Min { get; }
        public int Max { get; }

        public MinMax(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }
}
