using System;

namespace _704_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
            Console.WriteLine(Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
        }

        public static int Search(int[] nums, int target)
        {
            int i = -1;
            int l = 0;
            int r = nums.Length;


            while (l != r)
            {
                int m = (l + r) / 2;
                if (nums[m] == target)
                {
                    i = m;
                    break;
                }
                if (nums[m] > target)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            return i;
        }
    }
}
