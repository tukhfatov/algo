using System;

namespace SortArrayByParity2 {
    class Program {
        static void Main (string[] args) {
            int[] nums = new int[] { 4, 2, 5, 7 };
            var result = SortArrayByParity (nums);
            Console.WriteLine (string.Join (" ", result));

            var result2 = SortArrayByParitySecondSolution (nums);
            Console.WriteLine (string.Join (" ", result2));

        }

        public static int[] SortArrayByParitySecondSolution (int[] A) {
            var j = 1;
            for (int i = 0; i < A.Length; i += 2)
                if (A[i] % 2 == 1) {
                    while (A[j] % 2 == 1)
                        j += 2;

                    var tmp = A[i];
                    A[i] = A[j];
                    A[j] = tmp;
                }

            return A;
        }

        public static int[] SortArrayByParity (int[] A) {
            var i = 0;
            var oi = 1;
            var ei = 0;
            int[] result = new int[A.Length];
            while (i < A.Length) {
                if (A[i] % 2 == 0) {
                    result[ei] = A[i];
                    ei += 2;
                } else {
                    result[oi] = A[i];
                    oi += 2;
                }
                i++;
            }
            return result;
        }
    }
}