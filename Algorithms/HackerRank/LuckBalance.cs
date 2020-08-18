using System.Collections.Generic;
using System.Linq;

namespace Algorithms.HackerRank
{
    public static class LuckBalance
    {
        public static int Execute(int k, IEnumerable<int[]> contests)
        {
            var ordered = contests.OrderByDescending(x => x[0]);
            var luckBalance = 0;
            foreach (var contest in ordered)
            {
                if (contest[1] == 0)
                    luckBalance += contest[0];
                else if (k == 0)
                    luckBalance -= contest[0];
                else
                {
                    k--;
                    luckBalance += contest[0];
                }
            }

            return luckBalance;
        }

    }
}
