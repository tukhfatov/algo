using System;

namespace ArrayPartition {
    class Program {
        static void Main (string[] args) {
            int[] nums = new int[] { 1, 4, 3, 2 };
            var result = ArrayPairSum (nums);
            Console.WriteLine (result);
        }
        public static int ArrayPairSum (int[] nums) {
            Array.Sort (nums);
            int result = 0;
            for (int i = 0; i < nums.Length; i += 2) {
                result += nums[i];
            }
            return result;
        }
    }
}