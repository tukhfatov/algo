using System;

namespace _1974_MinimumTimeToTypeWordUsingSpecialTypewriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinTimeToType("abc"));
            Console.WriteLine(MinTimeToType("bza"));
            Console.WriteLine(MinTimeToType("zjpc"));

        }

        public static int MinTimeToType(string word)
        {
            int s = 0;
            int cur = 'a';

            foreach (char l in word)
            {
                int cc = Math.Abs(cur - l);
                if (cc > 13)
                {
                    cc = 26 - cc;
                }
                s += cc + 1;
                cur = l;
            }

            return s;
        }
    }
}
