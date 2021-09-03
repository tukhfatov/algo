using System;

namespace _35_SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
            Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
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

        public static int SearchInsert(int[] nums, int target)
        {
            int ind = Search(nums, target);

            if (ind != -1)
            {
                return ind;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target)
                {
                    ind = i;
                    break;
                }
            }

            if (ind == -1)
            {
                ind = nums.Length;
            }

            return ind;
        }
    }
}
