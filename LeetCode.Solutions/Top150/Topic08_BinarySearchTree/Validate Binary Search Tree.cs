namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
    internal class Validate_Binary_Search_Tree
    {
        public bool IsValidBST(TreeNode root)
        {
            return valid(root, long.MinValue, long.MaxValue);
        }

        public bool valid(TreeNode root, long min, long max)
        {
            if (root == null)
                return true;
            if (!(root.val > min && root.val < max))
            {
                return false;
            }
            bool left = valid(root.left, min, root.val);
            bool right = valid(root.right, root.val, max);
            return left && right;
        }
    }
}
