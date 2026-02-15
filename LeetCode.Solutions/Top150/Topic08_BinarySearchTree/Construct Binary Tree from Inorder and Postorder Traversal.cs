namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
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
    internal class Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal
    {
        private int postIdx;
        private Dictionary<int, int> inorderIndex;

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            postIdx = postorder.Length - 1;

            inorderIndex = new Dictionary<int, int>(inorder.Length);
            for (int i = 0; i < inorder.Length; i++)
                inorderIndex[inorder[i]] = i;

            return Build(postorder, 0, inorder.Length - 1);
        }

        private TreeNode Build(int[] postorder, int left, int right)
        {
            if (left > right) return null;

            int rootVal = postorder[postIdx--];
            TreeNode root = new TreeNode(rootVal);

            int mid = inorderIndex[rootVal];

            root.right = Build(postorder, mid + 1, right);
            root.left = Build(postorder, left, mid - 1);

            return root;
        }
    }
}
