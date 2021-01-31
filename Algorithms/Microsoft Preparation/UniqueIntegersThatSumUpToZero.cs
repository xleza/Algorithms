namespace Algorithms
{
    public static class UniqueIntegersThatSumUpToZero
    {
        public static int[] Execute(int n)
        {
            var result = new int[n];
            for (var i = 0; i < result.Length / 2; i++)
            {
                result[i] = i + 1;
                result[result.Length - i - 1] = -result[i];
            }

            return result;
        }
    }
}
