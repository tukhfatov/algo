using System;

namespace _1572_MatrixDiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                DiagonalSum(new int[][]{
                    new int[]{1,2,3},
                    new int[]{4,5,6},
                    new int[]{7,8,9}
                })
            );

            Console.WriteLine(
                DiagonalSum(new int[][]{
                    new int[]{1,1,1,1},
                    new int[]{1,1,1,1},
                    new int[]{1,1,1,1},
                    new int[]{1,1,1,1}
                })
            );

            Console.WriteLine(
                DiagonalSum(new int[][]{
                    new int[]{5},
                })
            );

        }

        public static int DiagonalSum(int[][] mat)
        {
            int res = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                res += mat[i][i];
            }

            int j = mat.Length - 1;
            for (int i = 0; i < mat.Length; i++)
            {
                res += mat[i][j--];
            }

            if (mat.Length % 2 == 1)
            {
                res -= mat[mat.Length / 2][mat.Length / 2];
            }
            return res;
        }
    }
}
