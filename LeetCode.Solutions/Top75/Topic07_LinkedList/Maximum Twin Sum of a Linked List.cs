namespace LeetCode.Solutions.Top75.Topic07_LinkedList
{
    internal class Maximum_Twin_Sum_of_a_Linked_List
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

        public int PairSum(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                ListNode temp = slow.next;
                slow.next = prev;
                prev = slow;
                slow = temp;
            }
            int sum = 0;
            while (slow != null)
            {
                sum = Math.Max(sum, slow.val + prev.val);
                slow = slow.next;
                prev = prev.next;
            }

            return sum;
        }
    }
}
