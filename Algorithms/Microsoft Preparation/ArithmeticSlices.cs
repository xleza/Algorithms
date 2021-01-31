namespace Algorithms
{
    public static class ArithmeticSlices
    {
        public static int Execute(int[] A)
        {
            var count = 0;
            for (var i = 0; i < A.Length - 2; i++)
            {
                var diff = A[i] - A[i + 1];
                for (var j = i + 1; j < A.Length - 1; j++)
                {
                    if (A[j] - A[j + 1] == diff)
                    {
                        count++;
                    }
                    else
                        break;
                }
            }
            return count;
        }
    }
}
