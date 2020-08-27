using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class ShortestReachInGraph
    {
        public static int[] Execute(int n, int[][] edges, int startNode)
        {
            var graph = new HashSet<int>[n + 1];
            for (var i = 1; i <= n; i++)
            {
                graph[i] = new HashSet<int>();
            }
            foreach (var edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            var distances = Dfs(graph, startNode);

            var distancesExceptStart = new List<int>();
            for (var i = 1; i <= n; i++)
            {
                if (i == startNode)
                    continue;
                distancesExceptStart.Add(distances[i] == 0 ? -1 : distances[i] * 6);
            }

            return distancesExceptStart.ToArray();
        }

        private static int[] Dfs(HashSet<int>[] graph, int start)
        {
            var queue = new Queue<int>();
            var visited = new HashSet<int>();
            var distances = new int[graph.Length];

            queue.Enqueue(start);
            visited.Add(1);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                foreach (var child in graph[node])
                {
                    if (visited.Contains(child))
                        continue;

                    queue.Enqueue(child);
                    visited.Add(child);

                    distances[child] = distances[node] + 1;
                }
            }

            return distances;
        }
    }
}
