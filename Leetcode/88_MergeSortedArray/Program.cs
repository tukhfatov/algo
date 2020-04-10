using System;

namespace _88_MergeSortedArray {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = new int[] { 2, 5, 6 };
            int n = 3;

            Merge (nums1, m, nums2, n);

            nums1 = new int[] { 2, 0 };
            m = 1;
            nums2 = new int[] { 1 };
            n = 1;

            Merge (nums1, m, nums2, n);
        }

        public static void Merge (int[] nums1, int m, int[] nums2, int n) {
            if (nums2.Length == 0) {
                return;
            }
            int l = m + n;
            int[] res = new int[l];

            int i = 0;
            int i1 = 0;
            int i2 = 0;

            while (i < l) {
                if (i1 < m && i2 < n) {
                    if (nums1[i1] < nums2[i2]) {
                        res[i] = nums1[i1];
                        i1++;
                    } else {
                        res[i] = nums2[i2];
                        i2++;
                    }
                } else {
                    if (i2 < n) {
                        res[i] = nums2[i2];
                        i2++;
                    } else {
                        res[i] = nums1[i1];
                        i1++;
                    }
                }
                Console.WriteLine (i1 + "   " + i2);
                i++;
            }

            for (i = 0; i < l; i++) {
                Console.Write (res[i] + " ");
                nums1[i] = res[i];
            }
        }
    }
}