namespace Algorithms
{
    public static class FrogRiverOne
    {
        public static int Execute(int x, int[] arr)
        {
            var count = 0;
            var aux = new int[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                var auxIndex = arr[i] - 1;
                if (auxIndex > aux.Length - 1)
                    return -1;

                if (arr[i] > x || aux[arr[i] - 1] != 0) continue;
              
                aux[arr[i] - 1]++;
                count++;

                if (count == x)
                    return i;
            }
            return -1;
        }
    }
}
