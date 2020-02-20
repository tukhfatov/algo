using System;
using System.Collections.Generic;

namespace _572_SubtreeOfAnotherTree {
    class Program {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode (int x) { val = x; }
            public TreeNode () { }
        }
        static void Main (string[] args) {

            var s = new TreeNode {
                val = 3,
                left = new TreeNode {
                val = 4,
                left = new TreeNode {
                val = 1,
                left = new TreeNode {
                val = 0
                }
                },
                right = new TreeNode {
                val = 2
                }
                },
                right = new TreeNode {
                val = 5
                }
            };

            var t = new TreeNode {
                val = 4,
                left = new TreeNode {
                val = 1,
                },
                right = new TreeNode {
                val = 2
                }
            };

            Console.WriteLine (IsSubtree (s, t));
        }
        public static bool Sub (TreeNode s, TreeNode t) {
            Queue<TreeNode> q = new Queue<TreeNode> ();
            Queue<TreeNode> subQ = new Queue<TreeNode> ();

            q.Enqueue (s);
            subQ.Enqueue (t);

            while (q.Count != 0 && subQ.Count != 0) {
                TreeNode tmp = q.Dequeue ();
                TreeNode subTmp = subQ.Dequeue ();

                if (tmp.val != subTmp.val) {
                    return false;
                }
                if (tmp.left != null) {
                    q.Enqueue (tmp.left);
                }
                if (subTmp.left != null) {
                    subQ.Enqueue (subTmp.left);
                }
                if (tmp.right != null) {
                    q.Enqueue (tmp.right);
                }
                if (subTmp.right != null) {
                    subQ.Enqueue (subTmp.right);
                }
            }
            if (q.Count > 0 || subQ.Count > 0) {
                return false;
            }
            return true;
        }

        public static bool IsSubtree (TreeNode s, TreeNode t) {

            Queue<TreeNode> q = new Queue<TreeNode> ();

            q.Enqueue (s);
            bool isSubFound = false;
            while (q.Count != 0) {
                TreeNode tmp = q.Dequeue ();
                if (tmp.val == t.val) {
                    isSubFound = Sub (tmp, t);
                }

                if (isSubFound) {
                    break;
                }
                if (tmp.left != null) {
                    q.Enqueue (tmp.left);
                }

                if (tmp.right != null) {
                    q.Enqueue (tmp.right);
                }
            }

            return isSubFound;
        }
    }
}