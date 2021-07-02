using System;
using System.Collections.Generic;

namespace _590_NaryTreePostorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Postorder(new Node
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
            if (root == null)
            {
                return;
            }
            if (root.children != null)
            {
                foreach (var item in root.children)
                {
                    Dfs(item, ref res);
                }
            }
            res.Add(root.val);
        }

        public static IList<int> Postorder(Node root)
        {
            var res = new List<int>();

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
