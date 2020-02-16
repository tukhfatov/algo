using System;

namespace _437_PathSum

{

    public class TreeNode

    {

        public int val;

        public TreeNode left;

        public TreeNode right;

        public TreeNode (int x) { val = x; }

        public TreeNode () {

        }

    }

    class Program {

        static void Main (string[] args) {

            var root = new TreeNode {
                val = 10,
                left = new TreeNode {
                val = 5,
                left = new TreeNode {
                val = 3,
                left = new TreeNode {
                val = 3
                },
                right = new TreeNode {
                val = -2
                }
                },
                right = new TreeNode {
                val = 2,
                right = new TreeNode {
                val = 1
                }
                }
                },
                right = new TreeNode {
                val = -3,
                right = new TreeNode {
                val = 11
                }
                }
            };

            Console.WriteLine ("Total: " + PathSum (root, 8));

            root = new TreeNode {
                val = 1,
                left = new TreeNode {
                val = 2
                }
            };
            Console.WriteLine ("Total: " + PathSum (root, 2));

            root = new TreeNode {
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
            Console.WriteLine ("Total: " + PathSum (root, 3));

        }

        public static void Calc (TreeNode node, int sum, int total, ref int count) {
            if (node == null) {
                return;
            }
            if (node.left == null && node.right == null) {
                return;
            }

            if (total == sum) {
                count++;
            }

            if (node.left != null) {
                Calc (node.left, sum, total + node.left.val, ref count);
            }
            if (node.right != null) {
                Calc (node.right, sum, total + node.right.val, ref count);
            }
        }
        public static void IterateByRoot (TreeNode root, int sum, ref int count) {
            if (root == null) {
                return;
            }

            if (root.left != null) {
                IterateByRoot (root.left, sum, ref count);
                Calc (root.left, sum, root.left.val, ref count);
            }

            if (root.right != null) {
                IterateByRoot (root.right, sum, ref count);
                Calc (root.right, sum, root.right.val, ref count);
            }
        }
        public static int PathSum (TreeNode root, int sum) {
            int count = 0;
            if (root == null) {
                return count;
            }

            IterateByRoot (root, sum, ref count);
            Calc (root, sum, root.val, ref count);
            return count;

        }

    }

}