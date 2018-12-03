using System;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

            int[] a = new int[m];
            for (int i = 0; i < m; i++)
            {
                a[i] = int.Parse(array[i]);
            }

            Array.Sort(a);
            int min = int.MaxValue;
            for (int i = 0; i < m; i++)
            {
                if (i + n > m)
                {
                    break;
                }
                min = Math.Min(min, Math.Abs(a[i] - a[i + n - 1]));
            }


            Console.WriteLine(min);
        }    
    }
}
