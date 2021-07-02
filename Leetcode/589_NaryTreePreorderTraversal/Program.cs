using System.Collections.Generic;
using System;

namespace _589_NaryTreePreorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Preorder(new Node
            {
                val = 1,
                children = new List<Node>
                {
                    new Node(){
                        val = 3,
                        children = new List<Node>{
                            new Node(){
                                val = 5,
                            },
                            new Node(){
                                val = 6
                            }
                        }
                    },
                    new Node(){
                        val = 2,
                    },
                    new Node(){
                        val = 4
                    }
                }
            })));
        }

        public static void Dfs(Node root, ref List<int> res)
        {
            if (root.children == null)
            {
                return;
            }
            foreach (var item in root.children)
            {
                res.Add(item.val);
                Dfs(item, ref res);
            }
        }

        public static IList<int> Preorder(Node root)
        {
            var res = new List<int>();

            if (root == null)
            {
                return res;
            }

            res.Add(root.val);
            Dfs(root, ref res);

            return res;
        }
    }
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
