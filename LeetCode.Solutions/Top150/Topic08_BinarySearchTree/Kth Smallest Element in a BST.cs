namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
    internal class Kth_Smallest_Element_in_a_BST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            TreeNode current = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                current = stack.Pop();
                k--;
                if (k == 0)
                    return current.val;

                current = current.right;
            }
            return -1;

        }
    }
}
