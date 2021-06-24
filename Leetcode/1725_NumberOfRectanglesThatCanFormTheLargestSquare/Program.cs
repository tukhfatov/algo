using System.Collections.Generic;
using System;

namespace _1725_NumberOfRectanglesThatCanFormTheLargestSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountGoodRectangles(new int[][] {
                new int[] {5,8},
                new int[] {3,9},
                new int[] {5,12},
                new int[] {16,5},
            }));

            Console.WriteLine(CountGoodRectangles(new int[][] {
                new int[] {2,3},
                new int[] {3,7},
                new int[] {4,3},
                new int[] {3,7},
            }));
        }

        public static int CountGoodRectangles(int[][] rectangles)
        {
            int count = 0, mx = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                int m = Math.Min(rectangles[i][0], rectangles[i][1]);
                if (m > mx)
                {
                    mx = m;
                    count = 1;
                }

                else if (m == mx)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
