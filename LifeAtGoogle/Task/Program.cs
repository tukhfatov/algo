using System;
using System.Collections.Generic;

namespace Task {
    class Program {
        static void Main (string[] args) {
            int[] dataOne = new int[] { 1, 2, 3, 9 };
            int[] dataTwo = new int[] { 1, 2, 4, 4 };
            var sum = 8;

            Console.WriteLine (HasPairWithSum (dataOne, sum));
            Console.WriteLine (HasPairWithSum (dataTwo, sum));

            Console.WriteLine (HasPairWithSumSetSolution (dataOne, sum));
            Console.WriteLine (HasPairWithSumSetSolution (dataTwo, sum));

        }
        // First solution O(n), if array is sorted
        public static bool HasPairWithSum (int[] data, int sum) {
            var low = 0;
            var high = data.Length - 1;

            while (low < high) {
                var s = data[low] + data[high];
                if (s == sum) {
                    return true;
                } else if (s > sum) {
                    high--;
                } else {
                    low++;
                }
            }
            return false;
        }

        // Second solution, if array is unsorted
        public static bool HasPairWithSumSetSolution (int[] data, int sum) {
            var complements = new SortedSet<int> ();
            foreach (int item in data) {
                var value = 0;
                bool checkWithLastItem = complements.TryGetValue (item, out value);
                if (checkWithLastItem) {
                    return true;
                }
                complements.Add (sum - item);
            }
            return false;
        }
    }
}