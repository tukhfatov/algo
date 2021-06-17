using System;
using System.Collections.Generic;

namespace ToeplitzMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix3 = new int[][] {
                new int[] { 18 },
                new int[] { 66 }
            };
            Console.WriteLine(ToeplitzMatrixFunc(matrix3));

            int[][] matrix = new int[][] {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 1, 2, 3 },
                new int[] { 9, 5, 1, 2 }
            };

            Console.WriteLine(ToeplitzMatrixFunc(matrix));

            int[][] matrix2 = new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 2, }
            };
            Console.WriteLine(ToeplitzMatrixFunc(matrix2));

        }
        public static bool ToeplitzMatrixFunc(int[][] matrix)
        {
            int r = matrix.Length;
            int c = matrix[0].Length;

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i > 0 && j > 0 && matrix[i][j] != matrix[i - 1][j - 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}