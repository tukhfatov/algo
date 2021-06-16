using System;

namespace _1486_XOROperationInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XorOperation(4, 3));
        }

        public static int XorOperation(int n, int start)
        {
            int res = start;
            for (int i = 1; i < n; i++)
            {
                res = res ^ (start + 2 * i);
            }
            return res;
        }
    }
}
