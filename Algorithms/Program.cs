using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new[] { 2, 1, 5, 0 };
          //  SelectionSort.Sort(arr, (x, y) => x > y);
            InsertionSort.Sort(arr, (x, y) => x > y);
        }
    }
}
