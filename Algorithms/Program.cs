using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var r= new Program().NextGreaterElement(12);


            Console.ReadKey();
        }

        public int NextGreaterElement(int n)
        {
            var digits = GetDigits(n);
            var permutations = new List<int>();
            GeneratePermutations(digits, 0, permutations);
            var minNumber = int.MaxValue;

            foreach (var permutation in permutations)
            {
                if (permutation <= n)
                    continue;

                minNumber = Math.Min(minNumber, permutation);
            }

            return minNumber;
        }

        public List<int> GetDigits(int n)
        {
            var result = new List<int>();
            while (n > 0)
            {
                result.Add(n % 10);
                n /= 10;
            }

            return result;
        }

        public void GeneratePermutations(List<int> items, int currentIndex, List<int> result)
        {
            if (currentIndex == items.Count - 1)
            {
                result.Add(GetNumber(items));
                return;
            }

            for (var i = currentIndex; i < items.Count; i++)
            {
                Swap(i, currentIndex, items);
                GeneratePermutations(items, currentIndex + 1, result);
                Swap(currentIndex, i, items);
            }
        }

        public int GetNumber(List<int> digits)
        {
            var number = 0;
            foreach (var digit in digits)
            {
                number *= 10;
                number += digit;
            }

            return number;
        }

        public void Swap(int i, int j, List<int> items)
        {
            var temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }

        public class IntSortingStrategy : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x < y)
                    return -1;
                else if (x > y)
                    return 1;

                return 0;
            }
        }

        public static async Task OperationAsync()
        {
            await Task.Delay(2000);
        }

        public static int MyPow(int x, int y)
        {
            var result = x;
            for (var i = 1; i < y; i++)
                result *= x;

            return result;
        }

        public static int ToInt(string number)
        {
            var result = 0;
            for (var i = 0; i < number.Length; i++)
            {
                var digit = (int)(number[i] - '0');
                result = result * 10 + digit;
            }

            return result;
        }

        public static double ToDouble(string number)
        {
            var split = number.Split('.');
            var left = ToInt(split[0]);
            double right = 0;

            for (var i = split[1].Length - 1; i >= 0; i--)
            {
                right = right / 10 + (split[1][i] - '0') / 10.0;
            }

            return left + right;
        }

        public static double ToDoubleScientific(string number)
        {
            var split = number.Split('E');
            var left = ToDouble(split[0]);
            if (split.Length == 1)
                return left;

            return left * Math.Pow(10, ToInt(split[1]));
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        private static async Task Cancelable(CancellationToken token)
        {
            var tokenForDelay = new CancellationTokenSource();
            token.Register(() =>
            {
                tokenForDelay.Cancel();
            });

            await Task.Delay(100000, tokenForDelay.Token);
        }
        private static async Task Cancelable1(CancellationToken token)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                await Task.Delay(500);
                token.ThrowIfCancellationRequested();
            }
        }
    }
}
