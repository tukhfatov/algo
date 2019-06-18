using System;

namespace ArrivalOfTheGeneral
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

            int minPos = n-1, maxPos = 0;

            for (int i = 0; i < input.Length; i++){
                int cur = int.Parse(input[i]);
                if (cur > int.Parse(input[maxPos])) {
                    maxPos = i;
                }
            }
            for (int i = n-1; i >= 0; i--)
            {
                int cur = int.Parse(input[i]);
                if (cur < int.Parse(input[minPos]))
                {
                    minPos = i;
                }
            }
            int result = Math.Abs(n - minPos - 1) + maxPos - ((maxPos > minPos) ? 1 : 0);
            Console.WriteLine(result);
        }
    }
}
