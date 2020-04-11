using System;

namespace _236_LowestCommonAncestorOfABinaryTree {

    class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode (int x) { val = x; }
        public TreeNode () { }

    }

    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            TreeNode root = new TreeNode () {
                val = 3,
                left = new TreeNode () {
                val = 5,
                left = new TreeNode () {
                val = 6
                },
                right = new TreeNode () {
                val = 2,
                left = new TreeNode () {
                val = 7
                },
                right = new TreeNode () {
                val = 4
                }
                }
                },
                right = new TreeNode () {
                val = 1,
                left = new TreeNode () {
                val = 0,
                },
                right = new TreeNode () {
                val = 8
                }
                }
            };
            var p = new TreeNode () {
                val = 5
            };
            var q = new TreeNode () {
                val = 1
            };
            var res = LowestCommonAncestor (root, p, q);
            Console.WriteLine (res.val);
        }

        public static TreeNode LowestCommonAncestor (TreeNode root, TreeNode p, TreeNode q) {
            if (root == null) {
                return null;
            }

            if (root.val == p.val || root.val == q.val) {
                return root;
            }

            TreeNode l = LowestCommonAncestor (root.left, p, q);
            TreeNode r = LowestCommonAncestor (root.right, p, q);

            if (l != null && r != null) {
                return root;
            } else {
                return l != null ? l : r;
            }
        }
    }
}