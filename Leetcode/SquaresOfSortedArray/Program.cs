using System;

namespace SquaresOfSortedArray {
    class Program {
        static void Main (string[] args) {
            int[] inp = new int[] {-4, -1, 0, 3, 10 };
            var result = SortedSquares (inp);
        }

        public static int[] SortedSquares (int[] A) {
            var m = 0;
            for (var p = 0; p < A.Length; p++) {
                if (A[p] >= 0) {
                    m = p;
                    break;
                }
            }
            int[] s = new int[A.Length];

            var i = m - 1;
            var j = m;
            var c = 0;
            while (i >= 0 && j < A.Length) {
                if (A[i] * A[i] < A[j] * A[j]) {
                    s[c] = A[i] * A[i];
                    i--;
                } else {
                    s[c] = A[j] * A[j];
                    j++;
                }
                c++;
            }

            while (i >= 0) {
                s[c] = A[i] * A[i];
                i--;
                c++;
            }

            while (j < A.Length) {
                s[c] = A[j] * A[j];
                j++;
                c++;
            }
            Console.WriteLine (string.Join (" ", s));
            return s;
        }
    }
}