using System;

namespace _1876_SubstringsOfSizeThreeWithDistinctCharactes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountGoodSubstrings("xyzzaz"));
            Console.WriteLine(CountGoodSubstrings("aababcabc"));
        }


        // Sliding window
        public static int CountGoodSubstrings(string s)
        {
            int total = 0;
            for (int i = 1; i < s.Length - 1; i++)
            {
                if (s[i] != s[i - 1] && s[i - 1] != s[i + 1] && s[i] != s[i + 1])
                {
                    total++;
                }
            }

            return total;
        }
    }
}
