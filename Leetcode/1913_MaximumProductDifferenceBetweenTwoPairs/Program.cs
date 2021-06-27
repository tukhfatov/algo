using System;

namespace _1913_MaximumProductDifferenceBetweenTwoPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProductDifference(new int[] { 5, 6, 2, 7, 4 }));
            Console.WriteLine(MaxProductDifference(new int[] { 4, 2, 5, 9, 7, 4, 8 }));
        }

        public static int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);
            return (nums[nums.Length - 2] * nums[nums.Length - 1]) - (nums[0] * nums[1]);
        }
    }
}
