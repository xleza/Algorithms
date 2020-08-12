using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public static class PascalTriangle
    {
        public static IList<IList<int>> Execute(int numRows)
        {
            var rows = new List<IList<int>>();
            for (var i = 0; i < numRows; i++)
            {
                var row = new List<int>();
                for (var j = 0; j <= i; j++)
                {
                    var hasPreviousRow = i > 0;
                    var isEdge = !hasPreviousRow || j == 0 || j == i;
                    if (isEdge)
                    {
                        row.Add(1);
                        continue;
                    }

                    var previousRow = rows[i - 1];
                    row.Add(previousRow[j - 1] + previousRow[j]);
                }
                rows.Add(row);
            }

            return rows;
        }
    }
}
