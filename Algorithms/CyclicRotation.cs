namespace Algorithms
{
    public static class CyclicRotation
    {
        public static T[] Execute<T>(T[] arr, int rotationsCount)
        {
            var result = new T[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                var newPosition = (i + rotationsCount) % arr.Length;
                result[newPosition] = arr[i];
            }

            return result;
        }
    }
}
