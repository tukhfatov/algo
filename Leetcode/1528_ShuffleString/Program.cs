using System.Text;
using System;

namespace _1528_ShuffleString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RestoreString("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 }));
        }

        public static string RestoreString(string s, int[] indices)
        {
            StringBuilder res = new StringBuilder(s);
            for (int i = 0; i < indices.Length; i++)
            {
                res[indices[i]] = s[i];
            }

            return res.ToString();
        }
    }
}
