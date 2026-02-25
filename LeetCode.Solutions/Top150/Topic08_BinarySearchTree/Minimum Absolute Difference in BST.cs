namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
    internal class Minimum_Absolute_Difference_in_BST
    {
        int diff = int.MaxValue;
        TreeNode prev = null;
        private void inorder(TreeNode root)
        {
            if (root == null)
                return;
            inorder(root.left);
            if (prev != null)
                diff = Math.Min(diff, root.val - prev.val);
            prev = root;
            inorder(root.right);

        }

        public int GetMinimumDifference(TreeNode root)
        {
            inorder(root);
            return diff;
        }
    }
}
