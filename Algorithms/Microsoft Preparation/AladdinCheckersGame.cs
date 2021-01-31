using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class AladdinCheckersGame
    {
        public static int Execute(char[][] grid, int row, int col)
        {
            var points = new Stack<(int row, int col)>();
            var eatenPawns = new Stack<int>();
            points.Push((row, col));
            eatenPawns.Push(0);
            var maxPawns = 0;

            while (points.Count != 0)
            {
                var position = points.Pop();
                var eatenPawnsToPoint = eatenPawns.Pop();
                maxPawns = Math.Max(maxPawns, eatenPawnsToPoint);
                var canGoUpAndLeft = position.row > 1 && position.col > 1;
                var canGoUpAndRight = position.row > 1 && position.col < grid.Length - 2;

                if (!canGoUpAndLeft && !canGoUpAndRight)
                    continue;

                if (canGoUpAndLeft)
                {
                    var nextItem = grid[position.row - 1][position.col - 1];

                    if (nextItem == '.')
                    {
                        points.Push((position.row - 1, position.col - 1));
                        eatenPawns.Push(maxPawns);
                    }
                    else if (nextItem == 'X' && position.row > 0 && position.col > 0)
                    {
                        points.Push((position.row - 2, position.col - 2));
                        eatenPawns.Push(maxPawns + 1);
                    }
                }
                if (canGoUpAndRight)
                {
                    var nextItem = grid[position.row - 1][position.col + 1];

                    if (nextItem == '.')
                    {
                        points.Push((position.row - 1, position.col + 1));
                        eatenPawns.Push(maxPawns);
                    }
                    else if (nextItem == 'X' && position.row > 0 && position.col > 0)
                    {
                        points.Push((position.row - 2, position.col + 2));
                        eatenPawns.Push(maxPawns + 1);
                    }
                }
            }


            return maxPawns;
        }
    }
}
