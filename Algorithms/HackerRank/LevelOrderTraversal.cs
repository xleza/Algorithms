using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class LevelOrderTraversal
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        public static List<int> Execute(Node root)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(root);

            var traversedValues = new List<int>();

            while (queue.Count != 0)
            {
                var nodesCount = queue.Count;
                while (nodesCount != 0)
                {
                    var node = queue.Dequeue();
                    traversedValues.Add(node.Data);
                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }
                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                    nodesCount--;
                }
            }

            return traversedValues;
        }
    }
}
