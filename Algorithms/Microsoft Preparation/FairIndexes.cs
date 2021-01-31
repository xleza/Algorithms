namespace Algorithms
{
    public static class FairIndexes
    {
        public static int Execute(int[] a, int[] b)
        {
            var leftSumOfA = a[0];
            var leftSumOfB = b[0];
            var sumOfA = 0;
            var sumOfB = 0;

            for (var i = 0; i < a.Length; i++)
            {
                sumOfA += a[i];
                sumOfB += b[i];
            }

            var fairIndices = 0;
            for (var i = 1; i < a.Length; i++)
            {
                var rightSumOfA = sumOfA - leftSumOfA;
                var rightSumOfB = sumOfB - leftSumOfB;
                if (rightSumOfA == leftSumOfA && rightSumOfB == leftSumOfB && rightSumOfA == rightSumOfB)
                    fairIndices++;

                leftSumOfA += a[i];
                leftSumOfB += b[i];
            }


            return fairIndices;
        }
    }
}
