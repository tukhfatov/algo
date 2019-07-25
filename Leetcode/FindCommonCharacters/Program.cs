using System;
using System.Collections;
using System.Collections.Generic;
namespace FindCommonCharacters {
    class Program {
        static void Main (string[] args) {
            string[] A = new string[] { "bella", "label", "roller" };
            string[] A1 = new string[] { "acabcddd", "bcbdbcbd", "baddbadb", "cbdddcac", "aacbcccd", "ccccddda", "cababaab", "addcaccd" };
            string[] A2 = new string[] {
                "bbddabab",
                "cbcddbdd",
                "bbcadcab",
                "dabcacad",
                "cddcacbc",
                "ccbdbcba",
                "cbddaccc",
                "accdcdbb"
            };

            Console.WriteLine (string.Join (" ", CommonChars (A)));
            Console.WriteLine (string.Join (" ", CommonChars (A1)));
            Console.WriteLine (string.Join (" ", CommonChars (A2)));
        }

        public static Dictionary<char, int> Intersection (
            Dictionary<char, int> t1,
            Dictionary<char, int> t2) {

            Dictionary<char, int> res = new Dictionary<char, int> ();

            foreach (var i in t1) {
                if (t2.ContainsKey (i.Key)) {
                    res.Add (i.Key, Math.Min (t2[i.Key], i.Value));
                }
            }

            return res;
        }
        public static IList<string> CommonChars (string[] A) {

            Dictionary<char, int> t1 = new Dictionary<char, int> ();
            int i = 0;
            while (i < A[0].Length) {
                char key = A[0][i];
                if (t1.ContainsKey (key)) {
                    t1[key]++;
                } else {
                    t1.Add (key, 1);
                }
                i++;
            }
            for (int j = 1; j < A.Length; j++) {
                i = 0;
                Dictionary<char, int> tmp = new Dictionary<char, int> ();
                while (i < A[j].Length) {
                    char key = A[j][i];
                    if (tmp.ContainsKey (key)) {
                        tmp[key]++;
                    } else {
                        tmp.Add (key, 1);
                    }
                    i++;
                }
                t1 = Intersection (t1, tmp);
            }

            var result = new List<string> ();
            foreach (var item in t1) {
                int c = item.Value;
                while (c > 0) {
                    result.Add (item.Key.ToString ());
                    c--;
                }
            }

            return result;
        }
    }
}