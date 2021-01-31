using System.Collections.Generic;

namespace Algorithms
{
    public static class CountOfHoursVariations
    {
        public static int Solve(int a, int b, int c, int d)
        {
            var permutations = Permutation.Execute(new List<int> { a, b, c, d });
            var validHours = new HashSet<(int h1, int h2, int m1, int m2)>();
            foreach (var permutation in permutations)
            {
                if (IsValidHour(permutation[0], permutation[1], permutation[2], permutation[3]))
                    validHours.Add((permutation[0], permutation[1], permutation[2], permutation[3]));
            }

            return validHours.Count;
        }

        private static bool IsValidHour(int h1, int h2, int m1, int m2)
        {
            var hours = h1 * 10 + h2;
            var minutes = m1 * 10 + m2;

            return hours < 24 && minutes < 60;
        }
    }
}
