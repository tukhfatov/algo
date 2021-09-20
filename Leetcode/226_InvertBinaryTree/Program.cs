using System;

namespace _226_InvertBinaryTree
{

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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InvertTree(new TreeNode
            {
                val = 2,
                left = new TreeNode
                {
                    val = 3
                },
                right = new TreeNode
                {
                    val = 1
                }
            }));
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            InvertTree(root.left);
            InvertTree(root.right);

            TreeNode tmp = root.left;
            root.left = root.right;
            root.right = tmp;

            return root;
        }
    }
}
