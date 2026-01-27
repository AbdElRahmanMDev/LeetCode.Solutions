namespace LeetCode.Solutions.Shared.Topic05_HeapPriority_Queue
{
    internal class Last_Stone_Weight
    {
        public int LastStoneWeight(int[] stones)
        {
            var pq = new PriorityQueue<int, int>();
            for (int i = 0; i < stones.Length; i++)
            {
                pq.Enqueue(stones[i], -stones[i]);
            }

            while (pq.Count > 1)
            {
                var l1 = pq.Dequeue();
                var l2 = pq.Dequeue();

                if (l1 != l2)
                {
                    var res = l1 - l2;
                    pq.Enqueue(res, -res);
                }
            }
            pq.Enqueue(0, 0);

            return pq.Peek();
        }
    }
}
