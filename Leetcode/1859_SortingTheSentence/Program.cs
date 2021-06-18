using System.Collections.Generic;
using System.Text;
using System;

namespace _1859_SortingTheSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortSentence("is2 sentence4 This1 a3"));
        }

        public static string SortSentence(string s)
        {
            var sArr = s.Split(' ');

            Dictionary<int, string> t = new Dictionary<int, string>(sArr.Length);
            foreach (var i in sArr)
            {
                t.Add(Convert.ToInt32(i[i.Length - 1]) - '0' - 1, i.Substring(0, i.Length - 1));
            }

            StringBuilder res = new StringBuilder();
            for (int i = 0; i < t.Count; i++)
            {
                res.Append(t[i]);
                res.Append(" ");
            }

            return res.ToString().Trim();
        }

        // use less memory
        public static string SortSentenceWithoutStringBuilder(string s)
        {
            var sArr = s.Split(' ');

            string[] t = new string[sArr.Length];
            foreach (var i in sArr)
            {
                t[Convert.ToInt32(i[i.Length - 1]) - '0' - 1] = i.Substring(0, i.Length - 1);
            }

            return String.Join(' ', t).Trim();
        }
    }
}
