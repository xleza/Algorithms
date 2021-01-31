namespace Algorithms
{
    public static class MaxInsertsToObtainStringWithout3ConsecutiveA
    {
        public static int Execute(string str)
        {
            var count = 2;
            var aCount = 0;
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    count--;
                    aCount++;
                }
                else
                {
                    count += 2;
                    aCount = 0;
                }

                if (aCount == 3)
                    return -1;
            }

            return count;
        }
    }
}
