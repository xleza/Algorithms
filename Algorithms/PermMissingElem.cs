namespace Algorithms
{
    public static class PermMissingElem
    {
        public static int GetResult(int[] arr)
        {
            var aux = new int[arr.Length + 1];
            foreach (var item in arr)
            {
                aux[item - 1] = item;
            }

            for (var i = 0; i < aux.Length; i++)
            {
                if (aux[i] == 0)
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}
