using System;

namespace TransposeMatrix {
    class Program {
        static void Main (string[] args) {
            int[][] a = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            Print (Transpose (a));

            int[][] b = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            };

            Print (Transpose (b));
        }

        public static void Print (int[][] res) {
            for (int i = 0; i < res.Length; i++) {
                for (int j = 0; j < res[i].Length; j++) {
                    Console.Write (res[i][j] + " ");
                }
                Console.WriteLine ();
            }

        }
        public static int[][] Transpose (int[][] A) {
            int[][] result = new int[A[0].Length][];
            for (int i = 0; i < A[0].Length; i++) {
                result[i] = new int[A.Length];
                for (int j = 0; j < A.Length; j++) {
                    result[i][j] = A[j][i];
                }
            }
            return result;
        }
    }
}