using System;

namespace _1502_CanMakeArithmeticProgressionFromSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanMakeArithmeticProgression(new int[] { 3, 5, 1 }));
        }

        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int dif = Math.Abs(arr[0] - arr[1]);

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) != dif)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
