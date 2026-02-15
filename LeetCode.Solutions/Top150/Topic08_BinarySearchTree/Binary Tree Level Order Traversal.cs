namespace LeetCode.Solutions.Top150.Topic08_BinarySearchTree
{
    internal class Binary_Tree_Level_Order_Traversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }
            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                int count = q.Count;
                List<int> numbers = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    var x = q.Dequeue();
                    numbers.Add(x.val);
                    if (x.left != null)
                    {
                        q.Enqueue(x.left);
                    }
                    if (x.right != null)
                    {
                        q.Enqueue(x.right);
                    }

                }
                result.Add(numbers);
            }

            return result;
        }
    }
}
