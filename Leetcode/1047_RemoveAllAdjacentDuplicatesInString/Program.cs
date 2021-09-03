using System.Collections.Generic;
using System;

namespace _1047_RemoveAllAdjacentDuplicatesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates("abbaca"));
            Console.WriteLine(RemoveDuplicates("azxxzy"));
        }

        public static string RemoveDuplicates(string s)
        {
            Stack<char> st = new Stack<char>();

            foreach (char l in s)
            {
                if (st.Count > 0 && st.Peek() == l)
                {
                    st.Pop();
                }
                else
                {
                    st.Push(l);
                }
            }
            string res = "";
            foreach (char l in st)
            {
                res = l + res;
            }
            return res;
        }
    }
}
