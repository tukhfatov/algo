using System;
using System.Collections.Generic;

namespace Dragons
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

            int s = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            int[] x = new int[n];
            int[] y = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

                x[i] = int.Parse(input[0]);
                y[i] = int.Parse(input[1]);
            }
            Array.Sort(x, y);

            bool lost = false;
            for (int i = 0; i < n; i++)
            {
                if (s > x[i])
                {
                    s += y[i];
                }
                else
                {
                    lost = true;
                    break;
                }
            }
            Console.WriteLine(lost ? "NO" : "YES");
        }
    }
}
