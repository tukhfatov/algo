using System;

namespace SortArrayByParity {
    class Program {
        static void Main (string[] args) {
            int[] nums = new int[] { 3, 1, 2, 4 };
            var result = SortArrayByParity (nums);
        }

        public static int[] SortArrayByParity (int[] A) {
            var i = 0;
            var ec = 0;
            while (i < A.Length) {
                if (A[i] % 2 == 0) {
                    var tmp = A[ec];
                    A[ec] = A[i];
                    A[i] = tmp;
                    ec++;
                }
                i++;
            }
            Console.WriteLine (string.Join (" ", A));
            return A;
        }
    }
}