using System.Text;
using System;

namespace _1768_MergeStringsAlternately
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MergeAlternately("abc", "pqr"));
            Console.WriteLine(MergeAlternately("ab", "pqrs"));
            Console.WriteLine(MergeAlternately("abcd", "pq"));
        }

        public static string MergeAlternately(string word1, string word2)
        {
            int n = word1.Length >= word2.Length ? word1.Length : word2.Length;

            StringBuilder s = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (i < word1.Length)
                {
                    s.Append(word1[i]);
                }

                if (i < word2.Length)
                {
                    s.Append(word2[i]);
                }
            }

            return s.ToString();
        }

    }
}
