namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
    internal class Maximum_Depth_of_Binary_Tree
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
        //BFS solution
        public int MaxDepth(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root == null)
                return 0;
            int count = 0;
            queue.Enqueue(root);
            while (queue.Count() > 0)
            {
                int size = queue.Count();
                count++;
                for (int i = 0; i < size; i++)
                {
                    var temp = queue.Dequeue();
                    if (temp.left != null)
                        queue.Enqueue(temp.left);
                    if (temp.right != null)
                        queue.Enqueue(temp.right);
                }
            }
            return count;
        }

        //Recursive solution
        public int MaxDepth2(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return Math.Max(left, right) + 1;

        }
    }
}
