using System.Text;
using System;

namespace _1844_ReplaceAllDigitsWithCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceDigits("a1c1e1"));
            Console.WriteLine(ReplaceDigits("a1b2c3d4e"));
            Console.WriteLine(ReplaceDigits("a1c1e1"));
        }

        public static string ReplaceDigits(string s)
        {
            StringBuilder res = new StringBuilder(s.Length);

            for (int i = 0; i < s.Length; i += 2)
            {
                res.Append(s[i]);
                if (i + 1 <= s.Length - 1)
                {
                    res.Append((char)(s[i] + (s[i + 1] - '0')));
                }
            }

            return res.ToString();
        }
    }
}
