using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public static class BinaryTreeLowestCommonAncestor
    {
        public class TreeNode
        {
            public int Data;
            public TreeNode Left;
            public TreeNode Right;
            public TreeNode(int x) { Data = x; }

        }

        public TreeNode Execute(TreeNode root, TreeNode p, TreeNode q)
        {
            var stack = new Stack<TreeNode>();
            var visited = new HashSet<TreeNode>();
            stack.Push(root);

            var foundedLeft = false;
            var foundedRight = false;

            while (stack.Count != 0)
            {
                var node = stack.Peek();

                if (visited.Contains(node))
                {
                    if (node.Right != null && !visited.Contains(node.Right))
                    {
                        stack.Push(node.Right);
                        continue;
                    }

                    stack.Pop();

                    if (Find(node, p.Data) && Find(node, q.Data))
                        return node;
                }

                visited.Add(node);

                if (node.Left != null)
                    stack.Push(node.Left);

            }

            return null;
        }

        public static bool Find(TreeNode root, int value)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (node.Data == value)
                    return true;

                if (node.Left != null)
                    stack.Push(node.Left);
                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }
            }

            return false;
        }
    }
}
