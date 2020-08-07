namespace Algorithms.HackerRank
{
    public static class LeftRotation
    {
        public static int[] Execute(int[] arr, int d)
        {
            var aux = new int[arr.Length];
            var rotations = d % arr.Length;
            if (rotations == 0)
                return arr;

            for (var i = 0; i < arr.Length; i++)
            {
                var nextIndex = i - rotations;
                if (nextIndex < 0)
                    nextIndex = arr.Length + nextIndex;

                aux[nextIndex] = arr[i];
            }

            return aux;
        }
    }
}
