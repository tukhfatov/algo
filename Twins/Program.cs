using System;

namespace Twins
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

            int[] array = new int[n];
            for (int i = 0; i < n;i++){
                array[i] = int.Parse(input[i]);
            }
            Array.Sort(array);
            int total = 0;
            for (int i = 0; i < n;i++){
                total += int.Parse(input[i]);
            }
            int tmp = total;
            int medium = total / 2 + (total % 2);
            int count = 0;
            for (int i = n - 1; i >= 0; i--){
                tmp = tmp - array[i];
                count++;
                if (tmp < medium){
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
