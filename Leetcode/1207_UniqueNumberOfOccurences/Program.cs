using System.Collections.Generic;
using System;

namespace _1207_UniqueNumberOfOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueOccurrences(new int[] { 1, 2, 2, 1, 1, 3 }));
            Console.WriteLine(UniqueOccurrences(new int[] { 1, 2 }));
            Console.WriteLine(UniqueOccurrences(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }));
        }

        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> a = new Dictionary<int, int>();

            foreach (int i in arr)
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
            int[] b = new int[1000];
            foreach (KeyValuePair<int, int> i in a)
            {
                if (b[i.Value] > 0)
                {
                    return false;
                }
                else
                {
                    b[i.Value] = i.Value;
                }
            }

            return true;
        }
    }
}
