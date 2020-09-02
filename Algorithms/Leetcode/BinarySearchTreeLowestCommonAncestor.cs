using System.Collections.Generic;

namespace Algorithms.Leetcode
{
    public static class BinarySearchTreeLowestCommonAncestor
    {
        public class TreeNode
        {
            public int Data;
            public TreeNode Left;
            public TreeNode Right;
            public TreeNode(int x) { Data = x; }
        }

        public static TreeNode Execute(TreeNode root, TreeNode p, TreeNode q)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            var left = p.Data < q.Data ? p.Data : q.Data;
            var right = q.Data > p.Data ? q.Data : p.Data;

            while (stack.Count != 0)
            {
                var node = stack.Pop();
                if (node.Data >= left && node.Data <= right)
                    return node;

                if (node.Data > left)
                    stack.Push(node.Left);
                else
                    stack.Push(node.Right);
            }

            return null;
        }
    }
}
