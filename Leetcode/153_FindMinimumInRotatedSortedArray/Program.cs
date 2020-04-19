using System;

namespace _153_FindMinimumInRotatedSortedArray {
    class Program {
        static void Main (string[] args) {

            int[] nums = new int[] {
                4,
                5,
                1,
                2,
                3
            };

            Console.WriteLine (FindMin (nums));

            nums = new int[] {
                1,
                2
            };

            Console.WriteLine (FindMin (nums));
        }

        public static int FindMin (int[] nums) {
            int l = 0;
            int r = nums.Length - 1;
            if (l == r) {
                return nums[l];
            }
            int p = 0;
            bool f = false;
            while (l <= r) {
                Console.WriteLine ("l: " + l + "   r:" + r);
                int m = (l + r) / 2;
                Console.WriteLine ("m: " + m);
                if (m == nums.Length - 1) {
                    break;
                }
                if (nums[m] > nums[m + 1]) {
                    p = m;
                    f = true;
                    break;
                } else {
                    if (nums[l] > nums[m]) {
                        r = m - 1;
                    } else {
                        l = m + 1;
                    }
                }
            }

            return f ? nums[p + 1] : nums[0];
        }
    }
}