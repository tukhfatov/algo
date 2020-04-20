using System;

namespace _1302_DeepestLeavesSum {

    class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode (int x) { val = x; }
    }

    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
        }

        public static int MaxHeight (TreeNode root) {
            if (root == null) {
                return 0;
            }

            return Math.Max (MaxHeight (root.left), MaxHeight (root.right)) + 1;
        }

        public static int S (TreeNode root, int h, int mh) {
            if (root == null) {
                return 0;
            }

            if (h == mh) {
                return root.val;
            }

            int l = S (root.left, h + 1, mh);
            int r = S (root.right, h + 1, mh);

            return l + r;
        }

        public static int DeepestLeavesSum (TreeNode root) {
            if (root == null) {
                return 0;
            }

            int maxHeight = MaxHeight (root);
            Console.WriteLine (maxHeight);
            int sum = S (root, 1, maxHeight);
            Console.WriteLine (sum);
            return sum;
        }
    }
}