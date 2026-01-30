namespace LeetCode.Solutions.Shared.Topic06_HeapPriority_Queue
{
    internal class Kth_Largest_Element_in_an_Array
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var pq = new PriorityQueue<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                pq.Enqueue(nums[i], nums[i]);

                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }

            return pq.Peek();
        }
    }
}
