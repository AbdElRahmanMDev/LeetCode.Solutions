namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
    internal class Path_Sum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;
            if (root.left == null && root.right == null)
                return targetSum == root.val;

            bool leftSum = HasPathSum(root.left, targetSum - root.val);
            bool rightSum = HasPathSum(root.right, targetSum - root.val);

            return leftSum || rightSum;



        }
    }
}
