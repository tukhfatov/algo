using System;

namespace _1832_CheckIfTheSentenceIsPangram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfPangram("thequickbrownfoxjumpsoverthelazydog"));
            Console.WriteLine(CheckIfPangram("leetcode"));
        }
        public static bool CheckIfPangram(string sentence)
        {
            int[] t = new int[26];
            foreach (var i in sentence)
            {
                int index = (int)i - 97;
                t[index]++;
            }


            bool res = true;
            for (int i = 0; i < 26; i++)
            {
                if (t[i] == 0)
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
    }
}
