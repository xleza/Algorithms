using System.Collections.Generic;

namespace Algorithms.HackerRank
{
    public static class IsBinarySearchTree
    {
        public class TreeNode
        {
            public int Data;
            public TreeNode Left;
            public TreeNode Right;
            public TreeNode(int data = 0, TreeNode left = null, TreeNode right = null)
            {
                Data = data;
                Left = left;
                Right = right;
            }
        }

        public static bool Execute(TreeNode root)
        {

            if (root == null)
                return true;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            var visited = new HashSet<TreeNode>();

            var previous = long.MinValue;

            while (stack.Count != 0)
            {
                var node = stack.Peek();

                if (visited.Contains(node))
                {
                    stack.Pop();

                    if (previous >= node.Data)
                    {
                        return false;
                    }

                    if (node.Right != null)
                        stack.Push(node.Right);

                    previous = node.Data;
                    continue;
                }


                visited.Add(node);
                if (node.Left != null)
                    stack.Push(node.Left);
            }

            return true;
        }
    }
}
