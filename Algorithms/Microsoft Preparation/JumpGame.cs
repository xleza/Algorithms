using System;
using System.Collections.Generic;

namespace Algorithms.Microsoft_Preparation
{
    public static class JumpGame
    {
        public static bool Execute(int[] arr, int start)
        {
            var visited = new HashSet<int>();
            var stack = new Stack<int>();
            stack.Push(start);
            visited.Add(start);

            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (arr[node] == 0)
                    return true;

                var leftPoint = node - arr[node];
                var rightPoint = node + arr[node];

                if (leftPoint >= 0 && !visited.Contains(leftPoint))
                {
                    stack.Push(leftPoint);
                    visited.Add(leftPoint);
                }

                if (rightPoint < arr.Length && !visited.Contains(rightPoint))
                {
                    stack.Push(rightPoint);
                    visited.Add(rightPoint);
                }
            }

            return false;
        }
    }
}
