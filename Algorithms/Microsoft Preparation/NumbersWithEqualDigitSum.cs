using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class NumbersWithEqualDigitSum
    {
        public static int Execute(int[] arr)
        {
            var maxNumbersLookUp = new Dictionary<int, List<int>>();
            foreach (var item in arr)
            {
                var digitSum = GetDigitsSum(item);
                if (!maxNumbersLookUp.ContainsKey(digitSum))
                    maxNumbersLookUp.Add(digitSum, new List<int>());

                var numbers = maxNumbersLookUp[digitSum];
                if (numbers.Count == 0)
                    numbers.Add(item);
                else if (numbers.Count == 1)
                {
                    if (numbers[0] >= item)
                        numbers.Add(item);
                    else
                    {
                        numbers.Add(numbers[0]);
                        numbers[0] = item;
                    }
                }
                else
                {
                    if (numbers[1] >= item)
                        continue;

                    if (numbers[0] > item)
                        numbers[1] = item;
                    else
                    {
                        numbers[1] = numbers[0];
                        numbers[0] = item;
                    }
                }
            }

            var max = -1;
            foreach (var item in maxNumbersLookUp)
            {
                if (item.Value.Count < 2)
                    continue;

                max = Math.Max(max, item.Value[0] + item.Value[1]);
            }

            return max;
        }

        private static int GetDigitsSum(int digit)
        {
            var sum = 0;
            while (digit != 0)
            {
                sum += digit % 10;
                digit /= 10;
            }

            return sum;
        }
    }
}
