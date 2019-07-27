using System;

namespace SumOfEvenNumbersAfterQueries {
    class Program {
        static void Main (string[] args) {
            int[] a = new int[] { 1, 2, 3, 4 };
            int[][] queries = new int[][] {
                new int[] { 1, 0 },
                new int[] {-3, 1 },
                new int[] {-4, 0 },
                new int[] { 2, 3 }
            };

            //            Console.WriteLine (string.Join (" ", SumEvenAfterQueries (a, queries)));
            Console.WriteLine (string.Join (" ", SumEvenAfterQueriesLeetCodeSolution (a, queries)));
        }
        public static int[] SumEvenAfterQueries (int[] A, int[][] queries) {
            int s = 0;
            foreach (int i in A) {
                if (i % 2 == 0) {
                    s += i;
                }
            }
            int[] result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++) {
                int val = queries[i][0];
                int index = queries[i][1];
                if (A[index] % 2 == 0) {
                    if ((A[index] + val) % 2 == 0) {
                        s = s - A[index] + (A[index] + val);
                    } else {
                        s = s - A[index];
                    }
                } else {
                    if ((A[index] + val) % 2 == 0) {
                        s = s + (A[index] + val);
                    }
                }
                A[index] = A[index] + val;
                result[i] = s;
            }
            return result;
        }

        public static int[] SumEvenAfterQueriesLeetCodeSolution (int[] A, int[][] queries) {
            int s = 0;
            foreach (int i in A) {
                if (i % 2 == 0) {
                    s += i;
                }
            }
            int[] result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++) {
                int val = queries[i][0];
                int index = queries[i][1];
                if (A[index] % 2 == 0) {
                    s -= A[index];
                }
                A[index] += val;
                if (A[index] % 2 == 0) {
                    s += A[index];
                }
                result[i] = s;
            }
            return result;
        }
    }
}