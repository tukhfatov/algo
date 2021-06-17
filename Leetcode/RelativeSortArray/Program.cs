using System;
using System.Collections.Generic;

namespace RelativeSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 2, 21, 43, 38, 0, 42, 33, 7, 24, 13, 12, 27, 12, 24, 5, 23, 29, 48, 30, 31 };
            int[] arr2 = new int[] { 2, 42, 38, 0, 43, 21 };
            int[] result = RelativeSortArray(arr1, arr2);
            Console.WriteLine(string.Join(" ", result));
            Console.WriteLine(string.Join(" ", RelativeSortArraySolutionWithoutSorting(arr1, arr2)));
        }

        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];

            Dictionary<int, int> tmp = new Dictionary<int, int>();
            for (int i = 0; i < arr2.Length; i++)
            {
                tmp.Add(arr2[i], 0);
            }
            Array.Sort(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                if (tmp.ContainsKey(arr1[i]))
                {
                    tmp[arr1[i]]++;
                }
                else
                {
                    tmp.Add(arr1[i], 1);
                }
            }

            int ind = 0;
            foreach (int i in tmp.Keys)
            {
                int val = tmp[i];
                while (val > 0)
                {
                    result[ind++] = i;
                    val--;
                }
            }
            return result;
        }

        public static int[] RelativeSortArraySolutionWithoutSorting(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];
            int[] c = new int[1001];
            for (int i = 0; i < arr1.Length; i++)
            {
                c[arr1[i]]++;
            }

            int ind = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                while (c[arr2[i]]-- > 0)
                {
                    result[ind++] = arr2[i];
                }
            }

            for (int i = 0; i < 1001; i++)
            {
                while (c[i]-- > 0)
                {
                    result[ind++] = i;
                }
            }
            return result;
        }
    }
}