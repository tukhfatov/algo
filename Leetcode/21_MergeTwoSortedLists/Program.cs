using System;
using System.Collections.Generic;

namespace _21_MergeTwoSortedLists {

    class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }
        public ListNode () { }
    }
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            ListNode a = new ListNode {
                val = 1,
                next = new ListNode {
                val = 2,
                next = new ListNode {
                val = 4
                }
                }
            };

            ListNode b = new ListNode {
                val = 1,
                next = new ListNode {
                val = 3,
                next = new ListNode {
                val = 4
                }
                }
            };

            Console.WriteLine (MergeTwoLists (a, b));

        }

        public static ListNode Insert (ListNode res, int val) {
            if (res == null) {
                res = new ListNode (val);
                return res;
            }
            ListNode toAdd = new ListNode (val);
            ListNode current = res;
            while (current.next != null) {
                current = current.next;
            }
            current.next = toAdd;

            return res;
        }

        public static ListNode MergeTwoLists (ListNode l1, ListNode l2) {
            ListNode res = null;

            while (true) {
                if (l1 == null && l2 == null) {
                    break;
                }
                if (l1 == null) {
                    res = Insert (res, l2.val);
                    l2 = l2.next;
                    continue;
                }
                if (l2 == null) {
                    res = Insert (res, l1.val);
                    l1 = l1.next;
                    continue;
                }
                if (l1.val < l2.val) {
                    res = Insert (res, l1.val);
                    l1 = l1.next;
                } else {
                    res = Insert (res, l2.val);
                    l2 = l2.next;
                }
            }

            while (res != null) {
                Console.Write ("   " + res.val);
                res = res.next;
            }

            return res;
        }
    }
}