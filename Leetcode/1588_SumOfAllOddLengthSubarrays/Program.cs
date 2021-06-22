using System;

namespace _1588_SumOfAllOddLengthSubarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOddLengthSubarrays(new int[] { 1, 4, 2, 5, 3 }));
            Console.WriteLine(SumOddLengthSubarrays(new int[] { 1, 2 }));
            Console.WriteLine(SumOddLengthSubarrays(new int[] { 10, 11, 12 }));
        }
        public static int SumOddLengthSubarrays(int[] arr)
        {
            int res = 0;
            int cur = 1;
            while (cur <= arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i + cur <= arr.Length)
                    {
                        for (int j = i; j < i + cur; j++)
                        {
                            res = res + arr[j];
                        }
                    }
                }
                cur = cur + 2;
            }
            return res;
        }

    }
}
