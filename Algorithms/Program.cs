using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new int[] { 2, 1, 5 };
            SelectionSort.Sort(arr, (x, y) => x > y);
        }
    }
}
