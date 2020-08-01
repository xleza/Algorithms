using System.Collections.Generic;

namespace Algorithms
{
    public sealed class StoneWall
    {
        public int Execute(int[] wallHeights)
        {
            var blocks = new Stack<int>();
            var result = 0;

            foreach (var item in wallHeights)
            {
                while (blocks.Count > 0 && blocks.Peek() > item)
                    blocks.Pop();

                if (blocks.Count == 0)
                {
                    blocks.Push(item);
                    result++;
                    continue;
                }

                if (blocks.Peek() == item)
                    continue;

                blocks.Push(item);
                result++;
            }

            return result;
        }
    }
}
