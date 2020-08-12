using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public static class PascalTriangleII
    {
        public static IList<int> Execute(int rowIndex)
        {
            var row = new int[rowIndex + 1];
            var prevRow = new int[rowIndex + 1];
            for (var i = 0; i <= rowIndex; i++)
            {
                row = new int[rowIndex + 1];

                for (var j = 0; j <= i; j++)
                {
                    var hasPreviousRow = i > 0;
                    var isEdge = !hasPreviousRow || j == 0 || j == i;
                    if (isEdge)
                    {
                        row[j] = 1;
                        continue;
                    }

                    row[j] = prevRow[j - 1] + prevRow[j];
                }
                prevRow = row;
            }

            return row;
        }
    }
}
