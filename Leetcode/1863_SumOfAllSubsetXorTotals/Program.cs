using System;
using System.Collections.Generic;

namespace _1863_SumOfAllSubsetXorTotals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubsetXORSum(new int[] { 1, 3 }));
            Console.WriteLine(SubsetXORSum(new int[] { 5, 1, 6 }));
            Console.WriteLine(SubsetXORSum(new int[] { 3, 4, 5, 6, 7, 8 }));

            Console.WriteLine(SubsetXORSumBacktracking(new int[] { 1, 3 }));
            Console.WriteLine(SubsetXORSumBacktracking(new int[] { 5, 1, 6 }));
            Console.WriteLine(SubsetXORSumBacktracking(new int[] { 3, 4, 5, 6, 7, 8 }));

        }

        public static int SubsetXORSum(int[] nums)
        {
            int res = 0;
            int powerOfNums = (int)Math.Pow(2, nums.Length);

            for (int i = 0; i < powerOfNums; i++)
            {
                int tmp = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        tmp ^= nums[j];
                    }
                }
                res += tmp;
            }
            return res;
        }

        public static void GenSubset(int[] nums, IList<int> subset, int index, ref int total)
        {
            int tmp = 0;
            for (int i = 0; i < subset.Count; i++)
            {
                tmp ^= subset[i];
            }
            total += tmp;

            for (int i = index; i < nums.Length; i++)
            {
                subset.Add(nums[i]);

                GenSubset(nums, subset, i + 1, ref total);

                subset.RemoveAt(subset.Count - 1);
            }
        }

        public static int SubsetXORSumBacktracking(int[] nums)
        {
            int res = 0;

            int index = 0;
            var subset = new List<int>();

            GenSubset(nums, subset, index, ref res);

            return res;
        }

    }
}
