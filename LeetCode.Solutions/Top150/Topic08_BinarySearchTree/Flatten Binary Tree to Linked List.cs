namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
    internal class Flatten_Binary_Tree_to_Linked_List
    {
        TreeNode dummy = new TreeNode(0);
        TreeNode current;
        public void Flatten(TreeNode root)
        {
            current = dummy;
            Preflatten(root);
            root = dummy.right;
        }
        public void Preflatten(TreeNode root)
        {
            if (root == null)
                return;
            current.right = root;
            current = current.right;
            TreeNode left = root.left;
            TreeNode right = root.right;
            root.left = null;
            root.right = null;
            Preflatten(left);
            Preflatten(right);
        }
    }
}
