using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public static class InorderTraversal
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

        public static IList<int> Execute(TreeNode root)
        {
            var traversedNodes = new List<int>();

            if (root == null)
                return traversedNodes;

            var stack = new Stack<TreeNode>();
            var visitedNodes = new HashSet<TreeNode>();

            stack.Push(root);

            while (stack.Count != 0)
            {
                var node = stack.Peek();

                if (!visitedNodes.Contains(node) && node.Left != null)
                {
                    visitedNodes.Add(node);
                    stack.Push(node.Left);
                    continue;
                }

                stack.Pop();
                traversedNodes.Add(node.Val);
                if (node.Right != null)
                    stack.Push(node.Right);
            }

            return traversedNodes;
        }
    }
}
