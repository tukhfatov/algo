using System.Collections.Generic;
using System;

namespace _1441_BuildAnArrayWithStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", BuildArray(new int[] { 1, 3 }, 3)));
            Console.WriteLine(string.Join(" ", BuildArray(new int[] { 1, 2, 3 }, 3)));
            Console.WriteLine(string.Join(" ", BuildArray(new int[] { 1, 2 }, 4)));
            Console.WriteLine(string.Join(" ", BuildArray(new int[] { 2, 3, 4 }, 4)));
        }

        public static IList<string> BuildArray(int[] target, int n)
        {
            List<string> result = new List<string>();

            int start = 1;
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] != start)
                {
                    while (target[i] != start)
                    {
                        result.Add("Push");
                        result.Add("Pop");
                        start++;
                    }
                }

                result.Add("Push");
                start++;
            }

            return result;
        }
    }
}
