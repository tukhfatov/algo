using System;

namespace _883_ProjectionAreaOf3DShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProjectionArea(new int[][]{
                new int[2]
            }));
        }
        public static int ProjectionArea(int[][] grid)
        {
            int total = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                int c = 0;
                int cm = Int32.MinValue;
                int rm = Int32.MinValue;
                for (int j = 0; j < grid[i].Length; j++)
                {
                    rm = Math.Max(rm, grid[i][j]);
                    cm = Math.Max(cm, grid[j][i]);
                    if (grid[i][j] > 0)
                    {
                        c++;
                    }
                }
                total += rm;
                total += cm;
                total += c;
            }

            return total;
        }
    }
}
