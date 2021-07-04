using System;

namespace _700_SearchInABinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new TreeNode
            {
                val = 4,
                left = new TreeNode
                {
                    val = 2,
                    left = new TreeNode
                    {
                        val = 1
                    },
                    right = new TreeNode
                    {
                        val = 3
                    }
                },
                right = new TreeNode
                {
                    val = 7
                }
            };

            TreeNode res = SearchBST(p, 2);
            Console.WriteLine(res.val + " " + res.left.val + " " + res.right.val);
        }

        public static TreeNode Dfs(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }
            else if (root.val < val)
            {
                return Dfs(root.right, val);
            }
            else
            {
                return Dfs(root.left, val);
            }
        }

        public static TreeNode SearchBST(TreeNode root, int val)
        {
            return Dfs(root, val);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
