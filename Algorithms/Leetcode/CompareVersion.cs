namespace Algorithms.Leetcode
{
    public static class CompareVersion
    {
        public static int Execute(string version1, string version2)
        {
            var segments1 = version1.Split('.');
            var segments2 = version2.Split('.');

            var maxSize = segments1.Length > segments2.Length ? segments1.Length : segments2.Length;

            for (var i = 0; i < maxSize; i++)
            {
                var segment1 = i < segments1.Length ? Parse(segments1[i]) : 0;
                var segment2 = i < segments2.Length ? Parse(segments2[i]) : 0;

                if (segment1 > segment2)
                    return 1;
                else if (segment1 < segment2)
                    return -1;
            }

            return 0;
        }

        private static int Parse(string segment)
        {
            if (segment.Length == 1)
                return int.Parse(segment);

            var numberStr = "";
            var i = 0;
            while (i < segment.Length && segment[i] == '0')
            {
                i++;
            }

            if (i == segment.Length)
                return 0;

            for (; i < segment.Length; i++)
                numberStr += segment[i];

            return int.Parse(numberStr);
        }
    }
}
