using System;
using System.Linq;

namespace Algorithms
{
    public sealed class LargestKSuchThatBothKAndKExistInArray
    {
        public static int Execute(int[] arr)
        {
            var max = 0;
            var numbersLookUp = arr.ToHashSet();

            foreach (var item in arr)
            {
                if (max >= Math.Abs(item))
                    continue;

                if (numbersLookUp.Contains(-item))
                    max = Math.Abs(item);
            }

            return max;
        }
    }
}
