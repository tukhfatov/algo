using System;
using System.Collections.Generic;

namespace _5380_StringMatchingInAnArray {
    class Program {
        static void Main (string[] args) {
            string[] words = new string[] { "mass", "as", "hero", "superhero" };
            var res = StringMatching (words);

            Console.WriteLine (string.Join (" ", res));

            words = new string[] { "leetcode", "et", "code" };
            res = StringMatching (words);

            Console.WriteLine (string.Join (" ", res));

            words = new string[] { "blue", "green", "bu" };
            res = StringMatching (words);

            Console.WriteLine (string.Join (" ", res));
        }

        public static IList<string> StringMatching (string[] words) {
            bool[] p = new bool[words.Length];
            for (int i = 0; i < words.Length; i++) {
                if (p[i]) {
                    continue;
                }
                int j = 0;
                while (j < words.Length) {
                    if (i != j && words[j].Contains (words[i])) {
                        p[i] = true;
                    }
                    j++;
                }
            }
            List<string> res = new List<string> ();
            for (int i = 0; i < words.Length; i++) {
                if (p[i]) {
                    res.Add (words[i]);
                }
            }
            return res;
        }
    }
}