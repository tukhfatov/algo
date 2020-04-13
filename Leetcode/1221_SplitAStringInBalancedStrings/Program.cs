using System;

namespace _1221_SplitAStringInBalancedStrings {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            string s = "RLRRLLRLRL";
            Console.WriteLine (BalancedStringSplit (s));

            s = "RLRRLLRLRL";
            Console.WriteLine (BalancedStringSplit (s));

        }

        public static int BalancedStringSplit (string s) {
            int c = 0;
            int cc = 0;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == 'R') {
                    c++;
                }
                if (s[i] == 'L') {
                    c--;
                }

                if (c == 0) {
                    cc++;
                }
            }

            return cc;
        }
    }
}