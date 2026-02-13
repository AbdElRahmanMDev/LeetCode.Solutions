namespace LeetCode.Solutions.Top75.Topic08_BinarySearchTree
{
    internal class Leaf_Similar_Trees
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

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> leaf1 = new List<int>();
            List<int> leaf2 = new List<int>();
            DFS(root1, leaf1);
            DFS(root2, leaf2);
            return leaf1.SequenceEqual(leaf2);


        }

        private void DFS(TreeNode root, List<int> leaf)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null)
            {
                leaf.Add(root.val);
                return;
            }

            DFS(root.left, leaf);
            DFS(root.right, leaf);
        }
    }
}
