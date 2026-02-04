namespace LeetCode.Solutions.Top75.Topic07_LinkedList
{
    internal class Odd_Even_Linked_List
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
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode currentEven = head;
            ListNode currentOdd = head.next;
            ListNode currentOddD = head.next;
            while (currentOdd != null && currentOdd.next != null)
            {
                currentEven.next = currentOdd.next;
                currentEven = currentEven.next;
                currentOdd.next = currentEven.next;
                currentOdd = currentOdd.next;
            }

            currentEven.next = currentOddD;

            return head;

        }
    }
}
