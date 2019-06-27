using System;
using System.Collections.Generic;

namespace FindAllNumbersDisappearedInAnArray {
    class Program {
        static void Main (string[] args) {
            int[] nums = new int[] { 10, 2, 5, 10, 9, 1, 1, 4, 3, 7 };
            var firstResult = FindAllNumbersDisappearedInAnArrayFirstSolution (nums);
            var secondResult = FindAllNumbersDisappearedInAnArraySecondSolution (nums);
            Console.WriteLine (string.Join (" ", secondResult));
        }

        public static IList<int> FindAllNumbersDisappearedInAnArraySecondSolution (int[] nums) {
            var result = new List<int> ();

            for (var i = 1; i <= nums.Length; i++) {
                var cur = Math.Abs (nums[i - 1]) - 1;

                if (nums[cur] > 0) {
                    nums[cur] = nums[cur] * (-1);
                }
            }

            for (var j = 0; j < nums.Length; j++) {
                if (nums[j] > 0) {
                    result.Add (j + 1);
                }
            }
            return result;
        }

        public static IList<int> FindAllNumbersDisappearedInAnArrayFirstSolution (int[] nums) {
            var result = new List<int> ();

            bool[] tmp = new bool[nums.Length];

            var i = 0;
            while (i < nums.Length) {
                tmp[nums[i] - 1] = true;
                i++;
            }

            for (var j = 0; j < nums.Length; j++) {
                if (!tmp[j]) {
                    result.Add (j + 1);
                }
            }
            return result;
        }
    }
}