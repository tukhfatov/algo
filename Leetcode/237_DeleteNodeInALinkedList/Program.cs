using System;

namespace _237_DeleteNodeInALinkedList
{
    class Program
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        static void Main(string[] args)
        {
            ListNode l = new ListNode(4);

            Console.WriteLine(DeleteNode(l));
        }

        public static void DeleteNode(ListNode node)
        {
            while (node != null)
            {
                node.val = node.next.val;
                if (node.next.next == null)
                {
                    node.next = null;
                }

                node = node.next;
            }

        }
    }
}
