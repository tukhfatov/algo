using System;
using System.Collections.Generic;

namespace _559_MaximumDepthOfNAryTree
{
    class Node
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxDepth(new Node(1, new List<Node>
            {
                new Node(3, new List<Node>{
                    new Node(5, new List<Node>()),
                    new Node(6, new List<Node>())
                }),
                new Node(2, new List<Node>()),
                new Node(4, new List<Node>())
            })));
        }

        public static int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int max = 1;
            foreach (var i in root.children)
            {
                max = Math.Max(max, MaxDepth(i) + 1);
            }

            return max;
        }
    }
}
