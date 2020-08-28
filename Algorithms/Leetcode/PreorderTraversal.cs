using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public static class PreorderTraversal
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

            public static IList<int> Execute(TreeNode root)
            {
                var traversedNodes = new List<int>();

                if (root == null)
                    return traversedNodes;

                var visited = new HashSet<TreeNode>();
                var stack = new Stack<TreeNode>();

                stack.Push(root);

                while (stack.Count != 0)
                {
                    var node = stack.Peek();
                    if (visited.Contains(node))
                    {
                        stack.Pop();

                        if (node.Right != null)
                            stack.Push(node.Right);

                        continue;
                    }

                    traversedNodes.Add(node.Val);
                    visited.Add(node);

                    if (node.Left != null)
                        stack.Push(node.Left);
                }

                return traversedNodes;
            }
        }
    }
}
