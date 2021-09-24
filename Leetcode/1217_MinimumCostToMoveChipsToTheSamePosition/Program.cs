using System;

namespace _1217_MinimumCostToMoveChipsToTheSamePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinCostToMoveChips(new int[] { 1, 2, 3 }));
            Console.WriteLine(MinCostToMoveChips(new int[] { 2, 2, 2, 3, 3 }));
            Console.WriteLine(MinCostToMoveChips(new int[] { 1, 1000000000 }));
        }

        public static int MinCostToMoveChips(int[] position)
        {
            int steps = 0;

            int o = 0;
            int e = 0;

            for (int i = 0; i < position.Length; i++)
            {
                if (position[i] % 2 == 1)
                {
                    o++;
                }
                else
                {
                    e++;
                }
            }

            steps = e > o ? o : e;
            return steps;
        }
    }
}
