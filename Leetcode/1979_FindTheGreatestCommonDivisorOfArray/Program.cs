using System;

namespace _1979_FindTheGreatestCommonDivisorOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindGCD(new int[] { 2, 5, 6, 9, 10 }));
            Console.WriteLine(FindGCD(new int[] { 7, 5, 6, 8, 3 }));
            Console.WriteLine(FindGCD(new int[] { 3, 3 }));
        }


        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;

            if (b == 0)
                return a;

            if (a == b)
                return a;

            if (a > b)
            {
                return gcd(a - b, b);
            }
            return gcd(a, b - a);
        }


        public static int FindGCD(int[] nums)
        {
            int mn = Int32.MaxValue;
            int mx = Int32.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                mn = Math.Min(mn, nums[i]);
                mx = Math.Max(mx, nums[i]);
            }


            return gcd(mn, mx);
        }
    }
}
