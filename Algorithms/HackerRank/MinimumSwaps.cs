namespace Algorithms.HackerRank
{
    public static class MinimumSwaps
    {
        public static int Execute(int[] arr)
        {
            var swaps = 0;
            for (var i = 0; i < arr.Length;)
            {
                var inOrder = arr[i] == i + 1;
                if (inOrder)
                {
                    i++;
                    continue;
                }

                var newIndex = arr[i] - 1;
                var temp = arr[newIndex];
                arr[newIndex] = arr[i];
                arr[i] = temp;
                swaps++;
            }

            return swaps;
        }
    }
}
