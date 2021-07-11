using System.Text;
using System;

namespace _557_ReverseWordsInStringIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("Let's take LeetCode contest"));
            Console.WriteLine(ReverseWords("God Ding"));

        }

        public static string ReverseWords(string s)
        {
            string[] words = s.Split();

            StringBuilder res = new StringBuilder(s.Length);

            foreach (var word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    res.Append(word[i]);
                }
                res.Append(" ");
            }

            return res.ToString().Trim();
        }
    }
}
