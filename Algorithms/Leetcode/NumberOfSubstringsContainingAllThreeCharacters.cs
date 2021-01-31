namespace Algorithms
{
    public static class NumberOfSubstringsContainingAllThreeCharacters
    {
        public static int Execute(string s)
        {
            var left = 0;
            var right = 0;
            var countA = 0;
            var countB = 0;
            var countC = 0;

            var count = 0;

            while (right < s.Length)
            {

                if (countA <= 0 || countB <= 0 || countC <= 0)
                {
                    if (s[right] == 'a')
                        countA++;
                    else if (s[right] == 'b')
                        countB++;
                    else
                        countC++;
                }
                else
                {
                    count += s.Length - right;
                    if (s[left] == 'a')
                        countA--;
                    else if (s[left] == 'b')
                        countB--;
                    else
                        countC--;

                    left++;
                }

                if (countA <= 0 || countB <= 0 || countC <= 0)
                    right++;
            }

            return count;
        }
    }
}
