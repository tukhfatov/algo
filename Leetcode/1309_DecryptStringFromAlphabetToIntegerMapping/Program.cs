using System;
using System.Text;

namespace _1309_DecryptStringFromAlphabetToIntegerMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string FreqAlphabets(string s)
        {
            int i = s.Length - 1;

            StringBuilder r = new StringBuilder();
            while (i >= 0)
            {
                int v = 0;
                if (s[i] == '#')
                {
                    Console.WriteLine(s.Substring(i - 2, 2));
                    v = Int32.Parse(s.Substring(i - 2, 2));
                    i -= 3;
                }
                else
                {
                    Console.WriteLine(s.Substring(i, 1));
                    v = Int32.Parse(s.Substring(i, 1));
                    i--;
                }
                r.Insert(0, (char)(v + 96));
            }

            return r.ToString();
        }
    }
}