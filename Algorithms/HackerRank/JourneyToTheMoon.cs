using System.Collections.Generic;
using System.Linq;

namespace Algorithms.HackerRank
{
    public sealed class JourneyToTheMoon
    {
        public static long Execute(int n, int[][] astronaut)
        {
            var graph = new HashSet<int>[n];
            for (var i = 0; i < n; i++)
            {
                graph[i] = new HashSet<int>();
            }

            var pointsToCover = new HashSet<int>();

            foreach (var item in astronaut)
            {
                graph[item[0]].Add(item[1]);
                graph[item[1]].Add(item[0]);
                pointsToCover.Add(item[1]);
                pointsToCover.Add(item[0]);
            }

            var coveredPointsTrack = new List<int>();
            while (pointsToCover.Count != 0)
            {
                var coveredPointsPerIteration = Dfs(graph, pointsToCover.First(), pointsToCover);
                coveredPointsTrack.Add(coveredPointsPerIteration.Count);
            }

            var componentsToSubtract = 0;
            foreach (var t in coveredPointsTrack)
            {
                componentsToSubtract += (t * (t - 1)) / 2;
            }

            return ((long)n * (n - 1)) / 2 - componentsToSubtract;
        }

        private static HashSet<int> Dfs(HashSet<int>[] graph, int start, HashSet<int> pointsToCover)
        {
            var stack = new Stack<int>();
            var visited = new HashSet<int>();
            stack.Push(start);
            visited.Add(start);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                pointsToCover.Remove(node);

                foreach (var child in graph[node])
                {
                    if (!visited.Contains(child))
                    {
                        stack.Push(child);
                        visited.Add(child);
                    }
                }
            }

            return visited;
        }
    }
}
