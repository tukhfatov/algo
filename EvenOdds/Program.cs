using System;

namespace EvenOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);

            long result = 0;
            if (n % 2 ==1){
                if ((k-1) <= n / 2)
                {
                    result = 2 * (k - 1) + 1;
                }
                else
                {
                    result = 2 * ((k -1) - n / 2);
                }

            }else{
                if (k <= n / 2)
                {
                    result = 2 * (k - 1) + 1;
                }
                else
                {
                    result = 2 * (k - n / 2);
                }
            }

            Console.WriteLine(result);
        }
    }
}
