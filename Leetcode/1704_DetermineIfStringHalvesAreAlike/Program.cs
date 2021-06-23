using System.Collections.Generic;
using System;

namespace _1704_DetermineIfStringHalvesAreAlike
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HalvesAreAlike("book"));
            Console.WriteLine(HalvesAreAlike("textbook"));
            Console.WriteLine(HalvesAreAlike("MerryChristmas"));
            Console.WriteLine(HalvesAreAlike("AbCdEfGh"));
        }

        public static bool HalvesAreAlike(string s)
        {

            List<char> v = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int c1 = 0, c2 = 0;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (v.IndexOf(s[i]) >= 0)
                {
                    c1++;
                }
            }
            for (int i = s.Length / 2; i < s.Length; i++)
            {
                if (v.IndexOf(s[i]) >= 0)
                {
                    c2++;
                }
            }

            return c1 == c2;
        }
    }
}
