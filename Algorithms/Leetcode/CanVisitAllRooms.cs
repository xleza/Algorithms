using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public sealed class CanVisitAllRooms
    {
        public static bool Execute(IList<IList<int>> rooms)
        {
            var graph = new bool[rooms.Count][];
            for (var i = 0; i < rooms.Count; i++)
            {
                graph[i] = new bool[rooms.Count];
                foreach (var key in rooms[i])
                {
                    graph[i][key] = true;
                }
            }

            return Dfs(graph) == rooms.Count;
        }

        private static int Dfs(bool[][] graph)
        {
            var points = new Stack<int>();
            var visited = new HashSet<int>();

            points.Push(0);
            visited.Add(0);

            while (points.Count > 0)
            {
                var point = points.Pop();
                for (var i = 0; i < graph[point].Length; i++)
                {
                    if (graph[point][i] && !visited.Contains(i))
                    {
                        points.Push(i);
                        visited.Add(i);
                    }
                }
            }

            return visited.Count;
        }
    }
}
