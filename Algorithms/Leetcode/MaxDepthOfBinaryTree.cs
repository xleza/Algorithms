using System;

namespace Algorithms.Leetcode
{
    public static class MaxDepthOfBinaryTree
    {
        public static int Execute(TreeNode root)
        {
            if (root == null)
                return 0;

            return Math.Max(Execute(root.left), Execute(root.right)) + 1;
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
