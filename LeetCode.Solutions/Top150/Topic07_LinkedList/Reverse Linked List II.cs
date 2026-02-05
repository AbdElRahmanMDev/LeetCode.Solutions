namespace LeetCode.Solutions.Top150.Topic07_LinkedList
{
    internal class Reverse_Linked_List_II
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


        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode LP = dummy;
            ListNode current = head;
            ListNode prev = null;
            for (int i = 0; i < left - 1; i++)
            {
                LP = current;
                current = current.next;
            }

            for (int i = 0; i < right - left + 1; i++)
            {
                ListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            LP.next.next = current;
            LP.next = prev;

            return dummy.next;


        }
    }
}
