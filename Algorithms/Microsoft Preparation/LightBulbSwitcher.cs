namespace Algorithms
{
    public static class LightBulbSwitcher
    {
        public static int Execute(int[] light)
        {
            var currentSum = 0;
            var blueMoments = 0;

            for (var i = 0; i < light.Length; i++)
            {
                currentSum += light[i];
                long n = i + 1;
                var sum = n * (n + 1);
                if (currentSum == (sum / 2))
                    blueMoments++;
            }

            return blueMoments;
        }
    }
}
