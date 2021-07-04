using System;

namespace _1920_BuildArrayFromPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", BuildArray(new int[] { 0, 2, 1, 5, 3, 4 })));
            Console.WriteLine(String.Join(" ", BuildArray(new int[] { 5, 0, 1, 2, 3, 4 })));
        }

        public static int[] BuildArray(int[] nums)
        {
            int[] res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = nums[nums[i]];
            }

            return res;
        }
    }
}
