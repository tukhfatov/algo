using System;
using System.Collections.Generic;

namespace _897_IncreasingOrderSearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TreeNode
            {
                val = 5,
                left = new TreeNode
                {
                    val = 3,
                    left = new TreeNode
                    {
                        val = 2,
                        left = new TreeNode
                        {
                            val = 1
                        }
                    },
                    right = new TreeNode
                    {
                        val = 4
                    }
                },
                right = new TreeNode
                {
                    val = 6,
                    right = new TreeNode
                    {
                        val = 8,
                        left = new TreeNode
                        {
                            val = 7
                        },
                        right = new TreeNode
                        {
                            val = 9
                        }
                    }
                }
            };
            Console.WriteLine(IncreasingBST(t));

            var t1 = new TreeNode
            {
                val = 5,
                left = new TreeNode
                {
                    val = 1
                },
                right = new TreeNode
                {
                    val = 7
                }
            };
            Console.WriteLine(IncreasingBST(t1));
        }

        public static void Dfs(TreeNode root, ref List<int> res)
        {
            if (root == null)
            {
                return;
            }
            Dfs(root.left, ref res);
            res.Add(root.val);
            Dfs(root.right, ref res);

        }

        public static TreeNode IncreasingBST(TreeNode root)
        {
            var res = new List<int>();
            Dfs(root, ref res);

            TreeNode result = new TreeNode(res[0]);
            TreeNode cur = result;
            for (int i = 1; i < res.Count; i++)
            {
                cur.right = new TreeNode(res[i]);
                cur = cur.right;
            }

            return result.right;
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
