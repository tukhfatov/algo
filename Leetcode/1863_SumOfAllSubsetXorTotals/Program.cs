using System;

namespace _1863_SumOfAllSubsetXorTotals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubsetXORSum(new int[] { 1, 3 }));
            Console.WriteLine(SubsetXORSum(new int[] { 5, 1, 6 }));
            Console.WriteLine(SubsetXORSum(new int[] { 3, 4, 5, 6, 7, 8 }));
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
                    //                    Console.WriteLine((i & (1 << j)));
                    if ((i & (1 << j)) > 0)
                    {
                        tmp ^= nums[j];
                        //Console.Write(nums[j] + " ");
                    }
                }
                //                Console.WriteLine("tmp: " + tmp);
                res += tmp;
            }
            return res;
        }
    }
}
