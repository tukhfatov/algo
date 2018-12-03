using System;

namespace Presents
{
    class Program
    {
        static void Main(string[] args)
        {
             int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int[] result = new int[n];
            for (int i = 0; i < input.Length; i++){
                result[int.Parse(input[i])-1] = i + 1;
            }

            for (int i = 0; i < result.Length; i++){
                Console.Write(result[i] + " ");
            }
        }
    }
}
