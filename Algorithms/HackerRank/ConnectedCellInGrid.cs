using System;
using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class ConnectedCellInGrid
    {
        public static int Execute(int[][] grid)
        {
            var visited = new HashSet<(int x, int y)>();
            var maxRegion = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] != 0 && !visited.Contains((i, j)))
                    {
                        maxRegion = Math.Max(maxRegion, Dfs(grid, visited, i, j));
                    }
                }
            }
            return maxRegion;
        }

        private static int Dfs(int[][] grid, HashSet<(int x, int y)> visited, int startX, int startY)
        {
            var visitedNumberPerIteration = 0;
            var stack = new Stack<(int x, int y)>();
            stack.Push((startX, startY));
            visited.Add((startX, startY));

            while (stack.Count != 0)
            {
                var (x, y) = stack.Pop();
                visitedNumberPerIteration++;

                var canGoUp = x - 1 >= 0;
                var canGoDown = x + 1 <= grid.Length - 1;
                var canGoLeft = y - 1 >= 0;
                var canGoRight = y + 1 <= grid[x].Length - 1;

                if (canGoUp && grid[x - 1][y] == 1 && !visited.Contains((x - 1, y)))
                {
                    stack.Push((x - 1, y));
                    visited.Add((x - 1, y));
                }
                if (canGoDown && grid[x + 1][y] == 1 && !visited.Contains((x + 1, y)))
                {
                    stack.Push((x + 1, y));
                    visited.Add((x + 1, y));
                }
                if (canGoLeft && grid[x][y - 1] == 1 && !visited.Contains((x, y - 1)))
                {
                    stack.Push((x, y - 1));
                    visited.Add((x, y - 1));
                }
                if (canGoRight && grid[x][y + 1] == 1 && !visited.Contains((x, y + 1)))
                {
                    stack.Push((x, y + 1));
                    visited.Add((x, y + 1));
                }
                if (canGoLeft && canGoUp && grid[x - 1][y - 1] == 1 && !visited.Contains((x - 1, y - 1)))
                {
                    stack.Push((x - 1, y - 1));
                    visited.Add((x - 1, y - 1));
                }
                if (canGoLeft && canGoDown && grid[x + 1][y - 1] == 1 && !visited.Contains((x + 1, y - 1)))
                {
                    stack.Push((x + 1, y - 1));
                    visited.Add((x + 1, y - 1));
                }
                if (canGoRight && canGoUp && grid[x - 1][y + 1] == 1 && !visited.Contains((x - 1, y + 1)))
                {
                    stack.Push((x - 1, y + 1));
                    visited.Add((x - 1, y + 1));
                }
                if (canGoRight && canGoDown && grid[x + 1][y + 1] == 1 && !visited.Contains((x + 1, y + 1)))
                {
                    stack.Push((x + 1, y + 1));
                    visited.Add((x + 1, y + 1));
                }
            }

            return visitedNumberPerIteration;
        }
    }
}
