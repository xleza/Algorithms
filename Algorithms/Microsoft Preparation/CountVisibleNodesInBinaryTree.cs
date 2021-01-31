using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class CountVisibleNodesInBinaryTree
    {
        public static int Execute(TreeNode root)
        {
            var nodes = new Stack<TreeNode>();
            var maxValues = new Stack<int>();
            nodes.Push(root);
            maxValues.Push(root.Value);

            var goodNodes = 0;

            while (nodes.Count != 0)
            {
                var currentNode = nodes.Pop();
                var currentMax = maxValues.Pop();

                if (currentNode.Value >= currentMax)
                    goodNodes++;

                if (currentNode.Left != null)
                {
                    nodes.Push(currentNode.Left);
                    maxValues.Push(Math.Max(currentMax, currentNode.Left.Value));
                }

                if (currentNode.Right != null)
                {
                    nodes.Push(currentNode.Right);
                    maxValues.Push(Math.Max(currentMax, currentNode.Right.Value));
                }
            }

            return goodNodes;
        }

        public class TreeNode
        {
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }
            public int Value { get; set; }
        }
    }
}
