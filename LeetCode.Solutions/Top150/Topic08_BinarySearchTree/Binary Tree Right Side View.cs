namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
    internal class Binary_Tree_Right_Side_View
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


        public IList<int> RightSideView(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            IList<int> list = new List<int>();
            if (root == null)
                return list;
            queue.Enqueue(root);
            while (queue.Count() > 0)
            {
                int size = queue.Count();

                for (int i = 0; i < size; i++)
                {
                    var x = queue.Dequeue();
                    if (i + 1 == size)
                        list.Add(x.val);
                    if (x.left != null)
                        queue.Enqueue(x.left);
                    if (x.right != null)
                        queue.Enqueue(x.right);
                }
            }

            return list;
        }
    }
}
