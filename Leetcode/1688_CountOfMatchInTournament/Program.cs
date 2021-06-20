using System;

namespace _1688_CountOfMatchInTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfMatches(7));
            Console.WriteLine(NumberOfMatches(14));
        }

        public static int NumberOfMatches(int n)
        {
            int res = 0;

            while (n > 1)
            {
                if (n % 2 == 1)
                {
                    res = res + (n - 1) / 2;
                    n = ((n - 1) / 2) + 1;
                }
                else
                {
                    res = res + n / 2;
                    n = n / 2;
                }
            }

            return res;

        }
    }
}
