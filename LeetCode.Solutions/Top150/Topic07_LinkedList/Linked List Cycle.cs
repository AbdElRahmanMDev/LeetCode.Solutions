namespace LeetCode.Solutions.Top150.Topic07_LinkedList
{
    internal class Linked_List_Cycle
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        public bool HasCycle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (slow.Equals(fast)) return true;
            }
            return false;
        }
    }
}
