using System;

namespace _1021_RemoveOutermostParentheses {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
        }

        public static string RemoveOuterParentheses (string S) {
            bool[] f = new bool[S.Length];
            Stack<char> st = new Stack<char> ();

            for (int i = 0; i < S.Length; i++) {
                if (S[i] == '(') {
                    st.Push ('(');
                }
                f[i] = (st.Count == 1);
                if (S[i] == ')') {
                    st.Pop ();
                }
            }
            StringBuilder res = new StringBuilder ();
            for (int i = 0; i < S.Length; i++) {
                if (!f[i]) {
                    res.Append (S[i]);
                }
            }

            return res.ToString ();

        }
    }
}