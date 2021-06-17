using System;

namespace ReshapeTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] m1 = new int[][] {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            int[][] result1 = MatrixReshape(m1, 1, 4);
            for (int i = 0; i < result1.Length; i++)
            {
                for (int j = 0; j < result1[i].Length; j++)
                {
                    Console.Write(result1[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[][] m2 = new int[][] {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            int[][] result2 = MatrixReshape(m2, 2, 4);

            for (int i = 0; i < result2.Length; i++)
            {
                for (int j = 0; j < result2[i].Length; j++)
                {
                    Console.Write(result2[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[][] m3 = new int[][] {
                new int[] { 1, 2, 3, 4 },
            };

            int[][] result3 = MatrixReshape(m3, 2, 2);

            for (int i = 0; i < result3.Length; i++)
            {
                for (int j = 0; j < result3[i].Length; j++)
                {
                    Console.Write(result3[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static int[][] MatrixReshape(int[][] nums, int r, int c)
        {

            if (nums.Length * nums[0].Length < r * c)
            {
                return nums;
            }

            int[][] result = new int[r][];
            int index = 0;
            for (int i = 0; i < r * c; i++)
            {
                if (index % c == 0)
                {
                    result[i / c] = new int[c];
                }
                result[i / c][i % c] = nums[index / nums[0].Length][index % nums[0].Length];
                index++;
            }
            return result;
        }
    }
}