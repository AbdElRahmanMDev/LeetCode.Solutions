namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
    internal class Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
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
        private int i;
        private Dictionary<int, int> inorderMap;
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            // 9→0, 3→1, 15→2, 20→3, 7→4                   0         4
            // Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
            i = 0;
            inorderMap = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                inorderMap[inorder[i]] = i;
            }
            return Helper(preorder, 0, inorder.Length - 1);
        }

        private TreeNode Helper(int[] preorder, int j, int k)
        {
            if (j > k)
                return null;

            int nodeVal = preorder[i++];
            TreeNode node = new TreeNode(nodeVal);
            int idx = inorderMap[nodeVal];
            node.left = Helper(preorder, j, idx - 1);
            node.right = Helper(preorder, idx + 1, k);
            return node;
        }
    }
}
