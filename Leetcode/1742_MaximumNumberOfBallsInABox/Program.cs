using System.Collections.Generic;
using System;

namespace _1742_MaximumNumberOfBallsInABox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBalls(1, 10));
            Console.WriteLine(CountBalls(5, 15));
            Console.WriteLine(CountBalls(19, 28));
        }

        public static int CountBalls(int lowLimit, int highLimit)
        {
            Dictionary<int, int> p = new Dictionary<int, int>();
            for (int i = lowLimit; i <= highLimit; i++)
            {
                int j = i;
                int tmp = 0;
                while (j != 0)
                {
                    tmp += j % 10;
                    j = j / 10;
                }
                if (p.ContainsKey(tmp))
                {
                    p[tmp]++;
                }
                else
                {
                    p[tmp] = 1;
                }
            }

            int m = 0;
            foreach (KeyValuePair<int, int> i in p)
            {
                if (i.Value > m)
                {
                    m = i.Value;
                }
            }
            return m;
        }
    }
}
