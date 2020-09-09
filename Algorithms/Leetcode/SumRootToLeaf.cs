using System;
using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public static class SumRootToLeaf
    {
        public class TreeNode
        {
            public int Val;
            public TreeNode Left;
            public TreeNode Right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                Val = val;
                Left = left;
                Right = right;
            }
        }

        public static int Execute(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var visited = new HashSet<TreeNode>();
            stack.Push(root);

            var totalSum = 0;

            while (stack.Count != 0)
            {
                var node = stack.Peek();

                if (node.Left == null && node.Right == null)
                {
                    var binary = "";
                    foreach (var bit in stack)
                    {
                        binary = bit.Val + binary;
                    }

                    totalSum += Convert.ToInt32(binary, 2);

                    visited.Add(node);
                    stack.Pop();
                    continue;
                }

                var containsNode = visited.Contains(node);

                if (!containsNode)
                {
                    visited.Add(node);
                    if (node.Left != null)
                        stack.Push(node.Left);

                    continue;
                }

                if (!visited.Contains(node.Right) && node.Right != null)
                {
                    stack.Push(node.Right);
                    continue;
                }

                stack.Pop();
            }

            return totalSum;
        }
    }
}
