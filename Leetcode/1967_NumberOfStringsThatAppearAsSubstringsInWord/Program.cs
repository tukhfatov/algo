using System;

namespace _1967_NumberOfStringsThatAppearAsSubstringsInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumOfStrings(new string[] { "a", "abc", "bc", "d" }, "abc"));
            Console.WriteLine(NumOfStrings(new string[] { "a", "b", "c" }, "aaaaabbbbb"));
            Console.WriteLine(NumOfStrings(new string[] { "a", "a", "a" }, "ab"));
        }

        public static int NumOfStrings(string[] patterns, string word)
        {
            int count = 0;

            foreach (string pattern in patterns)
            {
                if (word.Contains(pattern))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
