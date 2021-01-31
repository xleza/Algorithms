using System;

namespace Algorithms
{
    public static class MinStepsToMakePilesEqualHeight
    {
        public static int Execute(int[] piles)
        {
            var steps = 0;
            Array.Sort(piles);
            Array.Reverse(piles);

            for (var i = 1; i < piles.Length; i++)
            {
                if (piles[i] != piles[i - 1])
                    steps += i;
            }

            return steps;
        }
    }
}
