using System;

namespace _1913_MaximumProductDifferenceBetweenTwoPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProductDifference(new int[] { 5, 6, 2, 7, 4 }));
            Console.WriteLine(MaxProductDifferenceFaster(new int[] { 4, 2, 5, 9, 7, 4, 8 }));
        }
        //  Solution in O(nlogn)
        public static int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);
            return (nums[nums.Length - 2] * nums[nums.Length - 1]) - (nums[0] * nums[1]);
        }

        // Solution in O(n)
        public static int MaxProductDifferenceFaster(int[] nums)
        {
            int max1 = 0;
            int max2 = 0;
            int min1 = Int32.MaxValue;
            int min2 = Int32.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max1)
                {
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2)
                {
                    max2 = nums[i];
                }

                if (nums[i] < min1)
                {
                    min2 = min1;
                    min1 = nums[i];
                }
                else if (nums[i] < min2)
                {
                    min2 = nums[i];
                }
            }

            return (max1 * max2) - (min1 * min2);
        }

    }
}
