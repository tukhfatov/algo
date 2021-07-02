using System;

namespace _1837_SumOfDigitsInBaseK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumBase(34, 6));
            Console.WriteLine(SumBase(10, 10));
        }

        public static int SumBase(int n, int k)
        {
            int sum = 0;
            while (n > 0)
            {
                int p = n % k;
                sum += p;
                n = n / k;
            }

            return sum;
        }
    }
}
