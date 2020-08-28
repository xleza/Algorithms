using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public static class PostorderTraversal
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
                var visited = visitedNodes.Contains(node);

                if (visited)
                {
                    if (node.Right == null || visitedNodes.Contains(node.Right))
                    {
                        stack.Pop();
                        traversedNodes.Add(node.Val);
                    }
                    else if (node.Right != null)
                    {
                        stack.Push(node.Right);
                    }

                    continue;
                }

                visitedNodes.Add(node);
                if (node.Left != null)
                    stack.Push(node.Left);
            }

            return traversedNodes;
        }
    }
}
