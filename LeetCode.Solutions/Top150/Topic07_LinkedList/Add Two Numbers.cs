namespace LeetCode.Solutions.Top150.Topic07_LinkedList
{
    internal class Add_Two_Numbers
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

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            int carry = 0;
            while (l1 != null || l2 != null || carry != 0)
            {
                int v1 = l1 != null ? l1.val : 0;
                int v2 = l2 != null ? l2.val : 0;

                int value = v1 + v2 + carry;
                carry = value / 10;
                value = value % 10;

                current.next = new ListNode(value);
                current = current.next;

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }
            return dummy.next;
        }
    }
}
