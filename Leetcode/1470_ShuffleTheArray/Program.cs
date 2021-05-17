using System;

namespace _1470_ShuffleTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3)));
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[2 * n];

            int i = 0;
            int j = 0;
            while (i < n)
            {
                result[j] = nums[i];
                result[j + 1] = nums[i + n];

                j += 2;
                i++;
            }

            return result;
        }
    }
}
