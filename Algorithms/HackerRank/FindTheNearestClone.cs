using System;
using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class FindTheNearestClone
    {
        public static int Execute(int graphNodes, int[] graphFrom, int[] graphTo, long[] ids, int val)
        {
            var graph = new List<int>[10000000];
            for (var i = 0; i < graphFrom.Length; i++)
            {
                if (graph[graphFrom[i]] == null)
                    graph[graphFrom[i]] = new List<int>();
                if (graph[graphTo[i]] == null)
                    graph[graphTo[i]] = new List<int>();

                graph[graphFrom[i]].Add(graphTo[i]);
                graph[graphTo[i]].Add(graphFrom[i]);
            }

            var minPath = int.MaxValue;
            for (int i = 0; i < ids.Length; i++)
            {
                if (ids[i] != val)
                    continue;
                minPath = Math.Min(minPath, Bfs(graph, i + 1, ids));
                if (minPath == 1)
                    break;
            }
            return minPath;
        }

        private static int Bfs(List<int>[] graph, int start, long[] colors)
        {
            var visited = new HashSet<int>();
            var queue = new Queue<int>();
            var distances = new int[graph.Length];
            queue.Enqueue(start);
            visited.Add(start);
            distances[start] = 0;
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (start != node && colors[start - 1] == colors[node - 1])
                    return distances[node];
                foreach (var edge in graph[node])
                {
                    if (!visited.Contains(edge))
                    {
                        queue.Enqueue(edge);
                        visited.Add(edge);
                        distances[edge] = distances[node] + 1;
                    }
                }
            }
            return -1;
        }
    }
}
