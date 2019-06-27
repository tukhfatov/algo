using System;

namespace FlippingAnImage {
    class Program {
        static void Main (string[] args) {
            int[][] inp = new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 } };
            var result = FlipAndInvertImage (inp);
        }

        public static int[][] FlipAndInvertImage (int[][] A) {
            int[][] result = new int[A.Length][];
            for (var i = 0; i < A.Length; i++) {
                var k = 0;
                result[i] = new int[A[i].Length];
                for (var j = A[i].Length - 1; j >= 0; j--) {
                    result[i][k++] = 1 - A[i][j];
                }
            }

            for (var i = 0; i < result.Length; i++) {
                Console.WriteLine (string.Join (" ", result[i]));
            }

            return result;
        }
    }
}