using System;

namespace _687_LongestUnivaluePath
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public TreeNode() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var root = new TreeNode
            {
                val = 5,
                left = new TreeNode
                {
                    val = 4,
                    left = new TreeNode
                    {
                        val = 1
                    },
                    right = new TreeNode
                    {
                        val = 1
                    }
                },
                right = new TreeNode
                {
                    val = 5,
                    right = new TreeNode
                    {
                        val = 5
                    }
                }
            };

            Console.WriteLine(LongestUnivaluePath(root));

            root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 4,
                    left = new TreeNode
                    {
                        val = 4
                    },
                    right = new TreeNode
                    {
                        val = 4
                    }
                },
                right = new TreeNode
                {
                    val = 5,
                    right = new TreeNode
                    {
                        val = 5
                    }
                }
            };

            Console.WriteLine(LongestUnivaluePath(root));
        }

        public static int LongestUnivaluePath(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right.val == 0)
            {
                return 0;
            }

            if (root.left != null && root.val == root.left.val)
            {

                return 1;
            }
            if (root.right != null)
            {
                return LongestUnivaluePath(root.right);
            }

            return 0;
        }
    }
}