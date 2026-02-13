namespace LeetCode.Solutions.Top75.Topic08_BinarySearchTree
{
    internal class Search_in_a_Binary_Search_Tree
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


        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count() > 0)
            {
                int size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    var x = queue.Dequeue();
                    if (x.val == val)
                    {
                        return x;
                    }
                    if (x.left != null)
                        queue.Enqueue(x.left);
                    if (x.right != null)
                        queue.Enqueue(x.right);
                }
            }

            return null;
        }

        //Recursive Solution
        public TreeNode SearchBST2(TreeNode root, int val)
        {
            if (root == null)
                return null;
            if (root.val == val)
                return root;
            if (val < root.val) return SearchBST2(root.left, val);
            if (val > root.val) return SearchBST2(root.right, val);
            return null;
        }
    }
}
