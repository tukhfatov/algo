using System;

namespace _1614_MaximumNestingDepthOfTheParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxDepth("(1+(2*3)+((8)/4))+1"));
            Console.WriteLine(MaxDepth(""));
            Console.WriteLine(MaxDepth("()()"));
            Console.WriteLine(MaxDepth("()(()()))"));
            Console.WriteLine(MaxDepth("(1)+((2))+(((3)))"));
            Console.WriteLine(MaxDepth("1+(2*3)/(2-1)"));
            Console.WriteLine(MaxDepth("1"));
        }
        public static int MaxDepth(string s)
        {
            int count = 0;
            int open = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    open++;
                }

                if (s[i] == ')')
                {
                    count = Math.Max(count, open);
                    open--;
                }
            }

            return count;
        }
    }
}
