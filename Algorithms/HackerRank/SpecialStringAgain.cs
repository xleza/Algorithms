namespace Algorithms.HackerRank
{
    public static class SpecialStringAgain
    {
        public static long Execute(int n, string s)
        {
            long count = 0;
            for (var i = 0; i < n; i++)
            {
                var j = i + 1;
                for (; j < n; j++)
                {
                    var equal = s[i] == s[j];
                    if (equal)
                    {
                        count++;
                        continue;
                    }

                    var end = j + (j - i) + 1;
                    if (end > n)
                        break;

                    var areSame = true;
                    for (var k = j + 1; k < end; k++)
                    {
                        if (s[k] != s[i])
                            areSame = false;
                    }

                    if (areSame)
                        count++;

                    break;
                }
            }
            return count + n;
        }
    }
}
