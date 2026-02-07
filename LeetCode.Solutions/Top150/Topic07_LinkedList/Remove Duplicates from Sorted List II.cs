namespace LeetCode.Solutions.Top150.Topic07_LinkedList
{
    internal class Remove_Duplicates_from_Sorted_List_II
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

        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode prev = dummy;
            ListNode current = head;

            while (current != null)
            {
                bool hasduplicate = false;
                while (current.next != null && current.val == current.next.val)
                {
                    hasduplicate = true;
                    current = current.next;
                }
                if (hasduplicate)
                {
                    prev.next = current.next;
                }
                else
                {
                    prev = prev.next;
                }
                current = current.next;

            }
            return dummy.next;
        }
    }
}
