namespace Algorithms
{
    public static class LexicographicallySmallestString
    {
        public static string Execute(string str)
        {
            var indexToRemove = -1;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i] > str[i + 1])
                {
                    indexToRemove = i;
                }
            }

            if (indexToRemove == -1)
                indexToRemove = str.Length - 1;

            return str.Remove(indexToRemove, 1);
        }
    }
}
