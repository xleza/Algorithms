using System.Linq;

namespace Algorithms
{
    public sealed class PermutationCheck
    {
        public int Execute(int[] arr)
        {
            var aux = new int[arr.Length];
            foreach (var item in arr)
            {
                var index = item - 1;
                if (index > aux.Length - 1)
                    return 0;

                aux[index]++;
            }

            return aux.Any(item => item == 0) ? 0 : 1;
        }
    }
}
