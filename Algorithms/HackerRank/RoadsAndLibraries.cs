using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HackerRank
{
    public static class RoadsAndLibraries
    {
        public static long Execute(int n, int c_lib, int c_road, int[][] cities)
        {
            if (c_lib <= c_road)
                return (long)n * c_lib;

            var graph = new HashSet<int>[n + 1];
            var nodesToVisit = new List<int>();

            for (var i = 1; i <= n; i++)
            {
                graph[i] = new HashSet<int>();
                nodesToVisit.Add(i);
            }

            foreach (var city in cities)
            {
                graph[city[0]].Add(city[1]);
                graph[city[1]].Add(city[0]);

            }

            var visitedNodes = new HashSet<int>();
            long minimumAmount = 0;
            var startingNodeIndex = 0;
            while (visitedNodes.Count != n)
            {
                for (; startingNodeIndex < nodesToVisit.Count; startingNodeIndex++)
                {
                    if (!visitedNodes.Contains(nodesToVisit[startingNodeIndex]))
                        break;
                }

                if (startingNodeIndex == nodesToVisit.Count)
                    break;

                var visitedNodesNumber = Dfs(graph, nodesToVisit[startingNodeIndex]);
                minimumAmount += c_road * (visitedNodesNumber.Count - 1) + c_lib;

                foreach (var node in visitedNodesNumber)
                    visitedNodes.Add(node);

            }

            return minimumAmount;
        }

        private static HashSet<int> Dfs(HashSet<int>[] graph, int start)
        {
            var nodesToVisit = new Stack<int>();
            var visited = new HashSet<int>();
            nodesToVisit.Push(start);
            visited.Add(start);

            while (nodesToVisit.Count > 0)
            {
                var node = nodesToVisit.Pop();
                foreach (var neighbor in graph[node])
                {
                    if (!visited.Contains(neighbor))
                    {
                        nodesToVisit.Push(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            return visited;
        }
    }
}
