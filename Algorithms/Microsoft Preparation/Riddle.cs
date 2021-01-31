using System.Text;

namespace Algorithms
{
    public static class Riddle
    {
        public static string Execute(string riddle)
        {
            if (riddle.Length == 1)
                return riddle[0] == '?' ? "a" : riddle;

            var result = new StringBuilder();

            for (var i = 0; i < riddle.Length; i++)
            {
                if (riddle[i] != '?')
                {
                    result.Append(riddle[i]);
                    continue;
                }

                result.Append(GetProperLetter(riddle, i, result));
            }

            return result.ToString();
        }

        private static char GetProperLetter(string riddle, int currentIndex, StringBuilder result)
        {
            var hasNext = currentIndex < riddle.Length - 1;
            var hasPrevious = currentIndex > 0;

            for (var j = 0; j < 25; j++)
            {
                var currentLetter = (char)('a' + j);
                if (!hasPrevious && currentLetter != riddle[currentIndex + 1])
                {
                    return currentLetter;
                }
                if (hasPrevious && !hasNext && currentLetter != result[currentIndex - 1])
                {
                    return currentLetter;
                }
                if (hasPrevious && hasNext && currentLetter != result[currentIndex - 1] && currentLetter != riddle[currentIndex + 1])
                {
                    return currentLetter;
                }
            }

            return '?';
        }
    }
}
