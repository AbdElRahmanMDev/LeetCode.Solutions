namespace LeetCode.Solutions.Top75.Topic07_LinkedList
{
    internal class Merge_Two_Sorted_Lists
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


        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode current1 = list1;
            ListNode current2 = list2;

            ListNode dummy = new ListNode(0);
            ListNode node = dummy;

            while (current1 != null && current2 != null)
            {
                if (current1.val > current2.val)
                {
                    node.next = current2;
                    current2 = current2.next;
                }
                else
                {
                    node.next = current1;
                    current1 = current1.next;
                }
                node = node.next;
            }
            if (current1 != null)
            {
                node.next = current1;
            }
            else
            {
                node.next = current2;
            }
            return dummy.next;
        }
    }

}
