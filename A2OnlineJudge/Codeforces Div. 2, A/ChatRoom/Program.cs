using System;

namespace ChatRoom
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            bool result = false;
            string word = "hello";
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == word[start])
                {
                    start += 1;
                }
                if (start == word.Length)
                {
                    result = true;
                    break;
                }

            }
            Console.WriteLine(result ? "YES" : "NO");
        }
    }
}