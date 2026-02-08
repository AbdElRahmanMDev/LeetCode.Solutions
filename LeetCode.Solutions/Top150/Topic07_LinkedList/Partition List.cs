namespace LeetCode.Solutions.Top150.Topic07_LinkedList
{
    internal class Partition_List
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

        public class Solution
        {
            public ListNode Partition(ListNode head, int x)
            {

                ListNode dummy = new ListNode();
                ListNode dummy2 = new ListNode();
                ListNode smaller = dummy;
                ListNode greater = dummy2;
                ListNode current = head;
                while (current != null)
                {
                    if (current.val < x)
                    {
                        smaller.next = current;
                        smaller = smaller.next;
                    }
                    else
                    {
                        greater.next = current;
                        greater = greater.next;
                    }
                    current = current.next;
                }
                greater.next = null;
                smaller.next = dummy2.next;
                return dummy.next;
            }
        }
    }
}
