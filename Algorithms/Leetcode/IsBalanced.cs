using System;

namespace Algorithms.Leetcode
{
    public static class IsBalanced
    {
        public static bool Execute(TreeNode root)
        {
            if (root == null)
                return true;

            if (Math.Abs(GetSubtreeHeight(root.left) - GetSubtreeHeight(root.right)) > 1)
                return false;

            if (!Execute(root.left))
                return false;

            if (!Execute(root.right))
                return false;

            return true;
        }

        private static int GetSubtreeHeight(TreeNode node)
        {
            if (node == null)
                return 0;

            return Math.Max(GetSubtreeHeight(node.right), GetSubtreeHeight(node.left)) + 1;
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
