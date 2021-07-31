using System;

namespace _1710_MaximumUnitsOnATruck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumUnits(new int[][]{
                new int[] {1,3},
                new int[] {2,2},
                new int[] {3,1},

            }, 4));

            Console.WriteLine(MaximumUnits(new int[][] {
                new int[] {5,10},
                new int[] {2,5},
                new int[] {4,7},
                new int[] {3,9}
            }, 10));
        }

        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            int res = 0;

            Array.Sort(boxTypes, (a, b) => b[1] - a[1]);

            int i = 0;
            while (i < boxTypes.Length)
            {
                int b = boxTypes[i][0];
                int w = boxTypes[i][1];

                if (b < truckSize)
                {
                    res += b * w;
                    truckSize -= b;
                }
                else
                {
                    res += truckSize * w;
                    break;
                }
                i++;
            }

            return res;
        }
    }
}
