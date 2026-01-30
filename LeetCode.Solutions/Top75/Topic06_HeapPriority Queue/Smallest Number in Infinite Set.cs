namespace LeetCode.Solutions.Top75.Topic06_HeapPriority_Queue
{
    internal class Smallest_Number_in_Infinite_Set
    {
        PriorityQueue<int, int> pq;
        public Smallest_Number_in_Infinite_Set()
        {
            pq = new PriorityQueue<int, int>(Enumerable.Range(1, 1000).Select(x => (x, x)));
        }

        public int PopSmallest()
        {
            int smallest = pq.Dequeue();
            while (pq.Count > 0 && pq.Peek() == smallest)
                pq.Dequeue();
            return smallest;
        }

        public void AddBack(int num)
        {
            pq.Enqueue(num, num);
        }
    }
}
