using System;

namespace _111_MinimumDepthOfBinaryTree {
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode (int x) { val = x; }
        public TreeNode () { }
    }
    class Program {
        static void Main (string[] args) {

            var root = new TreeNode {
                val = 1,
                right = new TreeNode {
                val = 2,
                right = new TreeNode {
                val = 3,
                right = new TreeNode {
                val = 4,
                right = new TreeNode {
                val = 5
                }
                }
                }
                }
            };

            Console.WriteLine (MinDepth (root));

            root = new TreeNode {
                val = 3,
                left = new TreeNode {
                val = 9,
                // left = new TreeNode {
                // val = 1,
                // left = new TreeNode {
                // val = -1
                // }
                //}
                },
                right = new TreeNode {
                val = 20,
                left = new TreeNode {
                val = 15
                },
                right = new TreeNode {
                val = 7,
                }
                }
            };

            Console.WriteLine (MinDepth (root));
        }

        public static int MinDepth (TreeNode root) {
            if (root == null) {
                return 0;
            }
            if (root.left == null && root.right == null) {
                return 1;
            }

            if (root.left == null) {
                return MinDepth (root.right) + 1;
            }
            if (root.right == null) {
                return MinDepth (root.left) + 1;
            }

            Console.WriteLine ("No: " + root.val);
            return Math.Min (MinDepth (root.left), MinDepth (root.right)) + 1;
        }

    }
}