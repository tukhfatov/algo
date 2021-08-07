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

            HashSet<int> s = new HashSet<int>(a.Values);

            return s.Count == a.Count;
        }
    }
}
