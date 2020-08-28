using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.HackerRank
{
    public static class BinaryTreeHeight
    {
        static int Height(Node root)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(root);
            var height = 0;

            while (true)
            {
                var nodeCountOnLevel = queue.Count;
                if (nodeCountOnLevel == 0)
                    break;

                height++;

                for (var i = 0; i < nodeCountOnLevel; i++)
                {
                    var node = queue.Dequeue();
                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }
            }

            return height;
        }


        private class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }
    }
}
