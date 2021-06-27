using System;

namespace _1791_FindCenterOfStarGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindCenter(new int[][]{
                new int[]{1,2},
                new int[]{2,3},
                new int[]{4,2},
            }));

            Console.WriteLine(FindCenter(new int[][]{
                new int[]{1,2},
                new int[]{5,1},
                new int[]{1,3},
                new int[]{1,4},
            }));
        }

        public static int FindCenter(int[][] edges)
        {
            int[] a = new int[edges.Length + 1];

            for (int i = 0; i < edges.Length; i++)
            {
                a[edges[i][0] - 1]++;
                a[edges[i][1] - 1]++;
            }

            int res = 0;
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    res = i + 1;
                    max = a[i];
                }
            }

            return res;
        }
    }
}
