using System;

namespace _338_CountingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", CountBitsInN(2)));
            Console.WriteLine(String.Join(" ", CountBitsInN(5)));
            Console.WriteLine(String.Join(" ", CountBitsInN(30)));
        }

        public static int[] CountBits(int n)
        {
            int[] res = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                int c = 0;
                int j = i;
                while (j > 0)
                {
                    if (j % 2 == 1)
                    {
                        c++;
                    }
                    j = j / 2;
                }
                res[i] = c;
            }

            return res;
        }

        public static int[] CountBitsInN(int n)
        {
            int[] res = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                res[i] = res[i / 2] + i % 2;
            }

            return res;
        }
    }
}
