namespace Algorithms
{
    public static class MinSwapToMakePalindrome
    {
        public static int Execute(string str)
        {
            var swapCount = 0;
            var characters = str.ToCharArray();

            for (var i = 0; i < characters.Length / 2; i++)
            {
                var end = characters.Length - 1 - i;
                while (end > i && characters[i] != characters[end])
                {
                    end--;
                }

                if (end == i)
                    return -1;

                var correctPosition = str.Length - 1 - i;

                if (correctPosition == end)
                    continue;

                swapCount += correctPosition - end;

                for (var j = end; j < correctPosition; j++)
                {
                    var temp = characters[j + 1];
                    characters[j + 1] = characters[j];
                    characters[j] = temp;
                }
            }

            return swapCount;
        }
    }
}
