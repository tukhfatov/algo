using System;

namespace _1460_MakeTwoArraysEqualByReversingSubArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanBeEqual(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4, 1, 3 }));
            Console.WriteLine(CanBeEqual(new int[] { 7 }, new int[] { 7 }));
            Console.WriteLine(CanBeEqual(new int[] { 1, 12 }, new int[] { 12, 1 }));
            Console.WriteLine(CanBeEqual(new int[] { 3, 7, 9 }, new int[] { 3, 7, 11 }));
        }

        public static bool CanBeEqual(int[] target, int[] arr)
        {
            if (target.Length != arr.Length)
            {
                return false;
            }

            Array.Sort(target);
            Array.Sort(arr);


            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] != arr[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
