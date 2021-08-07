using System.Collections.Generic;
using System;

namespace _1022_SumOfRootToLeafBinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumRootToLeaf(new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 0,
                    left = new TreeNode
                    {
                        val = 0
                    },
                    right = new TreeNode
                    {
                        val = 1
                    }
                },
                right = new TreeNode
                {
                    val = 1,
                    left = new TreeNode
                    {
                        val = 0
                    },
                    right = new TreeNode
                    {
                        val = 1
                    }
                }
            }));

            Console.WriteLine(SumRootToLeaf(new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 1,
                },
            }));
        }


        private static int result = 0;
        public static void CalculateTree(TreeNode root, List<int> l)
        {
            l.Add(root.val);
            if (root.left != null)
            {
                CalculateTree(root.left, new List<int>(l));
            }

            if (root.right != null)
            {
                CalculateTree(root.right, new List<int>(l));
            }

            if (root.right == null && root.left == null)
            {
                int t = 0;
                int j = 1;
                foreach (var i in l)
                {
                    t += (i * (int)Math.Pow(2, l.Count - j));
                    j++;
                }
                result += t;

            }
        }

        public static int SumRootToLeaf(TreeNode root)
        {
            CalculateTree(root, new List<int>());
            return result;
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
