using System;

namespace _1464_MaximumProductOfTwoElementsInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProduct(new int[] { 3, 4, 5, 2 }));
            Console.WriteLine(MaxProduct(new int[] { 1, 5, 4, 5 }));
            Console.WriteLine(MaxProduct(new int[] { 3, 7 }));
        }

        public static int MaxProduct(int[] nums)
        {
            int max1 = 0, max2 = 0;
            foreach (var i in nums)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2)
                {
                    max2 = i;
                }
            }

            return (max1 - 1) * (max2 - 1);
        }
    }
}
