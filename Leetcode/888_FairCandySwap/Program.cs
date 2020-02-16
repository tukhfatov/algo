using System;

namespace _888_FairCandySwap {
    class Program {
        static void Main (string[] args) {

            int[] A = new int[] {
                1,
                1
            };

            int[] B = new int[] {
                2,
                2
            };

            int[] result = FairCandySwap (A, B);
            Console.WriteLine (result[0]);
            Console.WriteLine (result[1]);

            A = new int[] {
                2
            };

            B = new int[] {
                1,
                3
            };

            result = FairCandySwap (A, B);
            Console.WriteLine (result[0]);
            Console.WriteLine (result[1]);

            A = new int[] {
                1,
                2,
                5
            };

            B = new int[] {
                2,
                4
            };

            result = FairCandySwap (A, B);
            Console.WriteLine (result[0]);
            Console.WriteLine (result[1]);

            A = new int[] {
                35,
                17,
                4,
                24,
                10
            };

            B = new int[] {
                63,
                21
            };

            result = FairCandySwap (A, B);
            Console.WriteLine (result[0]);
            Console.WriteLine (result[1]);

        }

        public static int[] FairCandySwap (int[] A, int[] B) {
            int[] result = new int[2];

            int sumA = 0;
            for (int i = 0; i < A.Length; i++) {
                sumA += A[i];
            }
            int sumB = 0;
            for (int j = 0; j < B.Length; j++) {
                sumB += B[j];
            }

            int iA = 0;
            int iB = 0;
            while (true) {
                int curA = A[iA];
                int curB = B[iB];
                if ((sumA - curA + curB) == (sumB - curB + curA)) {
                    return new int[] { curA, curB };
                }
                if (iA < A.Length - 1) {
                    iA++;
                } else {
                    iB++;
                    iA = 0;
                }
            }
        }
    }
}