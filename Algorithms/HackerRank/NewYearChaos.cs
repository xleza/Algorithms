using System;

namespace Algorithms.HackerRank
{
    public sealed class NewYearChaos
    {
        public static void Execute(int[] q)
        {
            var totalBribes = 0;
            for (var i = q.Length - 1; i >= 0; i--)
            {
                var bribes = 0;
                for (var j = i; j < q.Length - 1; j++)
                {
                    if (q[j] < q[j + 1])
                        break;

                    var temp = q[j];
                    q[j] = q[j + 1];
                    q[j + 1] = temp;
                    bribes++;

                    if (bribes > 2)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }

                }

                totalBribes += bribes;
            }
            Console.WriteLine(totalBribes);
        }
    }
}
