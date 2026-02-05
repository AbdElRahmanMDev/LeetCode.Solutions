namespace LeetCode.Solutions.Top75.Topic07_LinkedList
{
    internal class Delete_the_Middle_Node_of_a_Linked_List
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

        public ListNode DeleteMiddle(ListNode head)
        {
            if (head.next == null)
                return null;
            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                fast = fast.next.next;
                slow = slow.next;
            }
            prev.next = prev.next.next;
            return head;
        }
    }
}
