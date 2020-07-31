namespace Algorithms
{
    public static class PassingCars
    {
        public static int Execute(int[] cars)
        {
            var zeroCount = 0;
            var result = 0;

            foreach (var item in cars)
            {
                if (item == 0)
                {
                    zeroCount++;
                    continue;
                }

                result += zeroCount;

                if (result > 1000000000)
                    return -1;
            }

            return result;
        }
    }
}
