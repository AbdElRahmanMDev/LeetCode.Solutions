namespace LeetCode.Solutions.Top75.Topic07_LinkedList
{
    public class Reverse_Linked_List
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
            public ListNode ReverseList(ListNode head)
            {
                ListNode prev = null;
                ListNode current = head;

                while (current != null)
                {
                    ListNode temp = current.next;
                    current.next = prev;
                    prev = current;
                    current = temp;
                }

                return prev;
            }
        }
    }

}
