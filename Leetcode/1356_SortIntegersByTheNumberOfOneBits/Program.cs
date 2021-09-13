using System.Collections.Generic;
using System.Collections.Specialized;
using System;

namespace _1356_SortIntegersByTheNumberOfOneBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", SortByBits(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 })));
        }

        public static int[] SortByBits(int[] arr)
        {
            Array.Sort(arr);
            SortedDictionary<int, List<int>> d = new SortedDictionary<int, List<int>>();
            foreach (int i in arr)
            {
                //Console.WriteLine(CountBits(i));
                int b = CountBits(i);
                if (d.ContainsKey(b))
                {
                    d[b].Add(i);
                }
                else
                {
                    d.Add(b, new List<int>{
                        i
                    });
                }
            }
            List<int> res = new List<int>();
            foreach (int i in d.Keys)
            {
                res.AddRange(d[i]);
            }
            return res.ToArray();
        }

        public static int CountBits(int a)
        {
            int c = 0;
            for (int i = 31; i >= 0; i--)
            {
                //Console.WriteLine(1 << i);
                if ((a & (1 << i)) > 0)
                {
                    c++;
                }
            }

            return c;
        }
    }
}
