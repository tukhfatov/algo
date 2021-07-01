using System;

namespace _1827_MinimumOperationsToMakeArrayIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinOperations(new int[] { 1, 1, 1 }));
            Console.WriteLine(MinOperations(new int[] { 1, 5, 2, 4, 1 }));
            Console.WriteLine(MinOperations(new int[] { 8 }));
        }

        public static int MinOperations(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }

            int res = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    int dif = Math.Abs(nums[i] - nums[i - 1]) + 1;
                    nums[i] += dif;
                    res += dif;
                }
            }

            foreach (var i in nums)
            {
                Console.Write(i + " ");
            }

            return res;
        }
    }
}
