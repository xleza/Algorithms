namespace Algorithms.Leetcode
{
    public static class RotateImage
    {
        public static void Execute(int[][] matrix)
        {
            var aux = new int[matrix.Length][];
            for (var i = 0; i < matrix.Length; i++)
            {
                aux[i] ??= new int[matrix[i].Length];
                for (var j = 0; j < matrix[i].Length; j++)
                {
                    aux[i][j] = matrix[matrix[i].Length - 1 - j][i];
                }
            }

            for (var i = 0; i < aux.Length; i++)
            {
                for (var j = 0; j < aux[i].Length; j++)
                {
                    matrix[i][j] = aux[i][j];
                }
            }
        }
    }
}