using System;

namespace _104_MaximumDepthOfBinaryTree {

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

            Console.WriteLine (MaxDepth (root));
        }

        public static int MaxDepth (TreeNode root) {
            if (root == null) {
                return 0;
            }

            return Math.Max (MaxDepth (root.left), MaxDepth (root.right)) + 1;
        }
    }
}