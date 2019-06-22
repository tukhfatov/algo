using System;

namespace MoveZeroes {
    class Program {
        static void Main (string[] args) {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroes (nums);
        }
        public static void MoveZeroes (int[] nums) {
            var i = 0;
            var z = 0;
            Console.WriteLine (string.Join (" ", nums));
            while (i < nums.Length) {
                var cur = nums[i];
                if (cur == 0) {
                    z++;
                }
                if (cur != 0 && z > 0) {
                    nums[i - z] = cur;
                    nums[i] = 0;
                }
                i++;
            }
            Console.WriteLine (string.Join (" ", nums));
        }
    }
}