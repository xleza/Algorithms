namespace Algorithms.HackerRank
{
    public static class JumpingOnClouds
    {
        public static int Execute(int[] c)
        {
            var jumpsCount = 0;

            for (var i = 0; i < c.Length - 1; i++)
            {
                if (i < c.Length - 2 && c[i + 2] == 0)
                {
                    i++;
                }
                jumpsCount++;
            }
            return jumpsCount;
        }
    }
}
