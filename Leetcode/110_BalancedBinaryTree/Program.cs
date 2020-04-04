using System;

namespace _110_BalancedBinaryTree {

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
                val = 9
                },
                right = new TreeNode {
                val = 20,
                left = new TreeNode {
                val = 15
                },
                right = new TreeNode {
                val = 7
                }
                }
            };

            Console.WriteLine (IsBalanced (root));

            root = new TreeNode {
                val = 1,
                left = new TreeNode {
                val = 2,
                left = new TreeNode {
                val = 3,
                left = new TreeNode {
                val = 4
                },
                right = new TreeNode {
                val = 4
                }
                },
                right = new TreeNode {
                val = 3
                }
                },
                right = new TreeNode {
                val = 2,
                }
            };

            Console.WriteLine (IsBalanced (root));

            root = new TreeNode {
                val = 1,
                right = new TreeNode {
                val = 2,
                right = new TreeNode {
                val = 3
                }
                }
            };

            Console.WriteLine (IsBalanced (root));
            root = new TreeNode {
                val = 1,
                left = new TreeNode {
                val = 2,
                left = new TreeNode {
                val = 3,
                left = new TreeNode {
                val = 4
                }
                }
                },
                right = new TreeNode {
                val = 2,
                right = new TreeNode {
                val = 3,
                right = new TreeNode {
                val = 4
                }
                }
                }
            };

            Console.WriteLine (IsBalanced (root));
        }

        public static int c (TreeNode root, ref bool res) {

            if (root == null) {
                return 0;
            }

            int lh = c (root.left, ref res);
            int rh = c (root.right, ref res);
            // Console.WriteLine (lh + "   " + rh + "    root: " + root.val);
            if (Math.Abs (lh - rh) > 1) {
                res = false;
            }
            return Math.Max (lh, rh) + 1;
        }

        public static bool IsBalanced (TreeNode root) {
            if (root == null) {
                return true;
            }
            bool res = true;
            c (root, ref res);
            // Console.WriteLine ("RESULT: " + res);
            return res;
        }

    }

}