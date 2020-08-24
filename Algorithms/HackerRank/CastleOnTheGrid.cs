using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class CastleOnTheGrid
    {
        private static int MinimumMoves(string[] grid, int startX, int startY, int goalX, int goalY)
        {
            var graph = GenerateGraph(grid);
            var queue = new Queue<int>();
            var visited = new HashSet<int>();
            var distances = new int[grid.Length * grid.Length];
            var start = GetElementValue(startX, startY, grid.Length);
            var goal = GetElementValue(goalX, goalY, grid.Length);

            queue.Enqueue(start);
            visited.Add(start);
            distances[start] = 0;

            while (queue.Count > 0)
            {
                var point = queue.Dequeue();
                if (point == goal)
                    return distances[point];

                for (var i = 0; i < graph[point].Length; i++)
                {
                    if (graph[point][i] == false || visited.Contains(i))
                        continue;

                    queue.Enqueue(i);
                    visited.Add(i);
                    distances[i] = distances[point] + 1;
                }
            }

            return 0;
        }

        private static bool[][] GenerateGraph(string[] grid)
        {
            var elementsNumber = grid.Length * grid.Length; // elements in graph
            var graph = new bool[elementsNumber][];

            for (var i = 0; i < grid.Length; i++)
            {

                for (var j = 0; j < grid.Length; j++)
                {
                    var row = GetElementValue(i, j, grid.Length);
                    if (graph[row] == null)
                        graph[row] = new bool[elementsNumber];

                    for (var k = j; k < grid.Length; k++)
                    {
                        if (grid[i][k] == 'X')
                            break;

                        graph[row][GetElementValue(i, k, grid.Length)] = true;
                    }

                    for (var k = j; k >= 0; k--)
                    {
                        if (grid[i][k] == 'X')
                            break;

                        graph[row][GetElementValue(i, k, grid.Length)] = true;
                    }

                    for (var k = i; k < grid.Length; k++)
                    {
                        if (grid[k][j] == 'X')
                            break;

                        graph[row][GetElementValue(k, j, grid.Length)] = true;
                    }

                    for (var k = i; k >= 0; k--)
                    {
                        if (grid[k][j] == 'X')
                            break;

                        graph[row][GetElementValue(k, j, grid.Length)] = true;
                    }
                }
            }
            return graph;
        }

        private static int GetElementValue(int row, int column, int length)
        {
            return row * length + column;
        }
    }
}
