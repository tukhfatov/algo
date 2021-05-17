using System;
using System.Linq;

namespace _1672_RichestCustomerWealth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumWealth(new int[][] { new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 } }));
        }

        public static int MaximumWealth(int[][] accounts)
        {
            int result = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                result = Math.Max(result, accounts[i].Sum());
            }

            return result;
        }
    }
}
