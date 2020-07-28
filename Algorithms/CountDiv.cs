namespace Algorithms
{
    public static class CountDiv
    {
        public static int GetResult(int fromRange, int toRange, int divisor)
        {
            var offset = 0;
            if (fromRange % divisor == 0)
                ++offset;

            return (fromRange / divisor) - (toRange / divisor) + offset;
        }
    }
}
