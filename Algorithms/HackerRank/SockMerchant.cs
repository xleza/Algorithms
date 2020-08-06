using System.Linq;

namespace Algorithms.HackerRank
{
    public static class SockMerchant
    {
        public static int Execute(int n, int[] arr)
        {
            return arr.GroupBy(x => x).Select(x => x.Count() / 2).Sum();
        }
    }
}
