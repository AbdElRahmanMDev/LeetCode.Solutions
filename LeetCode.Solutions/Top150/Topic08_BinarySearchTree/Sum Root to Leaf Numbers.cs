namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
    internal class Sum_Root_to_Leaf_Numbers
    {
        public int SumNumbers(TreeNode root)
        {
            return Dfs(root, 0);
        }

        private int Dfs(TreeNode node, int num)
        {
            if (node == null) return 0;
            if (node.left == null && node.right == null)
            {
                return num * 10 + node.val;
            }
            return Dfs(node.left, num * 10 + node.val) + Dfs(node.right, num * 10 + node.val);
        }
    }
}
