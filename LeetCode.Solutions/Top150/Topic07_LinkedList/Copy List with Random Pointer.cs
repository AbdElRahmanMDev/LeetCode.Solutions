namespace LeetCode.Solutions.Top150.Topic07_LinkedList
{
    internal class Copy_List_with_Random_Pointer
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        public Node CopyRandomList(Node head)
        {
            Node current = head;
            Dictionary<Node, Node> oldtocopy = new Dictionary<Node, Node>();
            while (current != null)
            {
                Node copy = new Node(current.val);
                oldtocopy[current] = copy;
                current = current.next;
            }
            current = head;
            while (current != null)
            {
                Node copy = oldtocopy[current];
                copy.next = current.next != null ? oldtocopy[current.next] : null;
                copy.random = current.random != null ? oldtocopy[current.random] : null;
                current = current.next;
            }

            return head != null ? oldtocopy[head] : null;
        }
    }
}
