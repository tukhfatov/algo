using System;

namespace _965_UnivaluedBinaryTree {
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

            TreeNode t = new TreeNode () {
                val = 1,
                left = new TreeNode {
                val = 1,
                left = new TreeNode {
                val = 1
                },
                right = new TreeNode {
                val = 1
                }
                },
                right = new TreeNode {
                val = 1,
                left = new TreeNode {
                val = 1
                }
                }
            };

            Console.WriteLine (IsUnivalTree (t));

        }
        public static int IsSame (TreeNode root) {
            if (root.left == null && root.right == null) {
                return root.val;
            }
            bool l = root.left != null ? IsSame (root.left) == root.val : true;
            bool r = root.right != null ? IsSame (root.right) == root.val : true;

            return l && r ? root.val : -1;
        }
        public static bool IsUnivalTree (TreeNode root) {
            if (root == null) {
                return true;
            }

            return IsSame (root) == root.val;
        }
    }
}