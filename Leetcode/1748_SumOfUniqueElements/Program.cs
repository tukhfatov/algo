using System.Collections.Generic;
using System;

namespace _1748_SumOfUniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfUnique(new int[] { 1, 2, 3, 2 }));
        }

        public static int SumOfUnique(int[] nums)
        {
            Dictionary<int, int> a = new Dictionary<int, int>();

            foreach (var i in nums)
            {
                if (a.ContainsKey(i))
                {
                    a[i]++;
                }
                else
                {
                    a[i] = 1;
                }
            }

            int res = 0;
            foreach (var (k, v) in a)
            {
                if (v == 1)
                {
                    res += k;
                }
            }

            return res;
        }
    }
}
