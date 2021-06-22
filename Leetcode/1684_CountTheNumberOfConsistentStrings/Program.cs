using System.Collections.Generic;
using System;

namespace _1684_CountTheNumberOfConsistentStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountConsistentStrings("ab", new string[] { "ad", "bd", "aaab", "baa", "badab" }));
            Console.WriteLine(CountConsistentStrings("abc", new string[] { "a", "b", "c", "ab", "ac", "bc", "abc" }));
            Console.WriteLine(CountConsistentStrings("cad", new string[] { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" }));
        }

        public static int CountConsistentStrings(string allowed, string[] words)
        {
            Dictionary<char, int> al = new Dictionary<char, int>();

            foreach (var i in allowed)
            {
                if (al.ContainsKey(i))
                {
                    al[i]++;
                }
                else
                {
                    al[i] = 1;
                }
            }
            int res = 0;
            foreach (var word in words)
            {
                bool ok = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (!al.ContainsKey(word[i]))
                    {
                        ok = false;
                        break;
                    }
                }


                if (ok) res++;
            }
            return res;
        }
    }
}
