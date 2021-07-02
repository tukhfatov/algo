using System;

namespace _1475_FinalPricesWithASpecialDiscountInAShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", FinalPrices(new int[] { 8, 4, 6, 2, 3 })));
            Console.WriteLine(String.Join(" ", FinalPrices(new int[] { 1, 2, 3, 4, 5 })));
            Console.WriteLine(String.Join(" ", FinalPrices(new int[] { 10, 1, 1, 6 })));
        }

        public static int[] FinalPrices(int[] prices)
        {

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        prices[i] = prices[i] - prices[j];
                        break;
                    }
                }
            }

            return prices;
        }
    }
}
