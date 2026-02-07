namespace LeetCode.Solutions.Top150.Topic07_LinkedList
{
    internal class Rotate_List
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return head;
            }
            ListNode tail = head;
            int size = 1;
            while (tail.next != null)
            {
                tail = tail.next;
                size++;
            }

            k = k % size;
            if (k == 0)
                return head;
            ListNode current = head;
            for (int i = 0; i < size - k - 1; i++)
            {
                current = current.next;
            }
            ListNode newHead = current.next;
            current.next = null;
            tail.next = head;

            return newHead;
        }
    }
}
