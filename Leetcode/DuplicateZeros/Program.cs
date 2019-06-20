using System;

namespace DuplicateZeros {
    class Program {
        static void Main (string[] args) {
            int[] data = new int[] { 9, 0, 9, 0, 6, 0, 0, 0, 1, 1, 6, 5, 4, 4, 8, 3, 0, 0, 0, 1, 5, 3, 0, 0, 7, 2, 1, 0, 2, 0, 9, 1, 0, 2, 0, 0, 0, 0, 0, 0, 0, 6, 0, 0, 7, 9, 0, 8, 7, 0, 9, 7, 1, 0, 2, 0, 0, 0, 0, 9, 0, 0, 0, 0 };
            //    int[] data = new int[] { 1, 0, 2, 3 };
            DuplicateZeros (data);
        }

        public static void DuplicateZeros (int[] arr) {
            var z = 0;
            for (var j = 0; j < arr.Length; j++) {
                if (arr[j] == 0) {
                    z++;
                }
            }
            var i = arr.Length - 1;
            var l = arr.Length - 1;
            while (i > 0) {
                var cur = i + z;
                if (arr[i] == 0) {
                    z--;
                }
                if (cur > l) {
                    arr[i] = 0;
                } else {
                    arr[i + z] = arr[i];
                    arr[cur] = arr[i];
                    arr[i] = arr[i - 1] == 0 ? 0 : arr[i];
                }
                i--;
            }
            Console.WriteLine (string.Join (" ", arr));
        }
    }
}