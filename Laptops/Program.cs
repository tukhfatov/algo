using System;

namespace Laptops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] a = new int[n];
            int [] b = new int[n];
            int [] diff = new int[n];
            for(int i=0; i<n;i++){
                string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);
                a[i] = int.Parse(input[0]);
                b[i] = int.Parse(input[1]);
                diff[i] = b[i] - a[i];
            }

            int max = int.MinValue;
            int min = int.MaxValue;

            for(int i=0; i<n;i++){
                if (diff[i] > max){
                    max = diff[i];
                }

                if (diff[i] < min){
                    min = diff[i];
                }
            }
            Console.WriteLine( max > min ? "Happy Alex": "Poor Alex");
        }
    }
}
