using System.Text;
using System;

namespace _1880_CheckIfWorkEqualsSummationOfTwoWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSumEqual("acb", "cba", "cdb"));
            Console.WriteLine(IsSumEqual("aaa", "a", "aab"));
            Console.WriteLine(IsSumEqual("aaa", "a", "aaaa"));
        }

        public static bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            int a = ConvertToInt(firstWord);
            int b = ConvertToInt(secondWord);
            int c = ConvertToInt(targetWord);
            return (a + b) == c;
        }

        public static int ConvertToInt(string a)
        {
            StringBuilder p = new StringBuilder(a.Length);
            foreach (var i in a)
            {
                p.Append(i - 'a');
            }

            return Convert.ToInt32(p.ToString());
        }
    }
}
