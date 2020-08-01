using System.Collections.Generic;

namespace Algorithms
{
    public static class Fish
    {
        public static int Execute(int[] A, int[] B)
        {
            var downStreams = new Stack<int>();
            var eatenFishes = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (B[i] == 1)
                {
                    downStreams.Push(i);
                }
                while (downStreams.Count != 0)
                {
                    eatenFishes++;
                    var downStream = A[downStreams.Peek()];
                    if (downStream > A[i])
                    {
                        break;
                    }
                    downStreams.Pop();
                }
            }
            return A.Length - eatenFishes;
        }
    }
}
