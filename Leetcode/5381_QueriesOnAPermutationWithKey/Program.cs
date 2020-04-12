using System;

namespace _5381_QueriesOnAPermutationWithKey {
    class Program {

        static void Main (string[] args) {
            int[] queries = new int[] {
                3,
                1,
                2,
                1
            };
            int m = 5;

            Console.WriteLine (string.Join (" ", ProcessQueries (queries, m)));

            queries = new int[] {
                4,
                1,
                2,
                2
            };
            m = 4;

            Console.WriteLine (string.Join (" ", ProcessQueries (queries, m)));

            queries = new int[] {
                7,
                5,
                5,
                8,
                3
            };
            m = 8;

            Console.WriteLine (string.Join (" ", ProcessQueries (queries, m)));
        }

        public static void GetPer (ref int[] list, int m) {

            // Console.WriteLine (m + " " + list[m]);
            int tmp = list[m];

            for (int i = m; i >= 1; i--) {
                list[i] = list[i - 1];
            }
            list[0] = tmp;
        }
        public static int[] ProcessQueries (int[] queries, int m) {
            int[] p = new int[m];
            int[] res = new int[queries.Length];

            for (int i = 0; i < m; i++) {
                p[i] = i + 1;
            }

            for (int i = 0; i < queries.Length; i++) {
                int ind = Array.IndexOf (p, queries[i]);
                GetPer (ref p, ind);
                res[i] = ind;

                Console.WriteLine (string.Join (" ", p));
            }

            return res;

        }
    }
}