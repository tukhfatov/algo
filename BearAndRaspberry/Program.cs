using System;

namespace BearAndRaspberry
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int c = int.Parse(input[1]);

            input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.None);
            int [] x = new int[n];

            for (int i=0; i<n;i++){
                x[i] = int.Parse(input[i]);
            }            

            int result = 0;
            for (int i=0; i<n-1;i++){
                result = Math.Max(result, x[i] - c - x[i+1]);
            }
            Console.WriteLine(result);
        }
    }
}
