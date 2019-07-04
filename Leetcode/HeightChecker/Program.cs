using System;

namespace HeightChecker {
    class Program {
        static void Main (string[] args) {
            int[] heights = new int[] { 1, 1, 4, 2, 1, 3 };
            Console.WriteLine (HeightChecker (heights));
        }
        public static int HeightChecker (int[] heights) {
            int[] tmp = new int[heights.Length];
            for (var i = 0; i < heights.Length; i++) {
                tmp[i] = heights[i];
            }
            Array.Sort (tmp);
            var count = 0;
            for (var i = 0; i < heights.Length; i++) {
                if (tmp[i] != heights[i]) {
                    count++;
                }
            }
            return count;
        }
    }
}