using System;

namespace Algorithms
{
    public static class Triangle
    {
        public static int GetResult(int[] arr)
        {
            Array.Sort(arr);

            var greatestElementInTriangle = arr[arr.Length - 1];
            var complement = greatestElementInTriangle / 2 + 1;

            var elementsFound = 1;
            for (var i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] >= complement)
                {
                    elementsFound++;

                    if (elementsFound == 3)
                        return 1;

                    complement = greatestElementInTriangle - arr[i] + 1;
                }
                else
                {
                    elementsFound = 1;
                    greatestElementInTriangle = arr[i];
                    complement = greatestElementInTriangle / 2 + 1;
                }
            }

            return 0;
        }
    }
}
