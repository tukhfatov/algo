using System;

namespace _1732_FindTheHighestAltitude
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestAltitude(new int[] { -5, 1, 5, 0, -7 }));
            Console.WriteLine(LargestAltitude(new int[] { -4, -3, -2, -1, 4, 3, 2 }));
        }
        public static int LargestAltitude(int[] gain)
        {
            int res = 0;
            int tmp = 0;
            foreach (int i in gain)
            {
                tmp = tmp + i;
                if (tmp > res)
                {
                    res = tmp;
                }
            }

            return res;
        }
    }
}
