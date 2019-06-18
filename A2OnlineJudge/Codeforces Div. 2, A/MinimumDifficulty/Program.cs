using System;
using System.Collections.Generic;

namespace MinimumDifficulty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int [] a = new int[n];
            for(int i=0; i<n; i++){
                a[i] = int.Parse(input[i]);
            }
            
            int k = 1;
            int result = int.MaxValue;
            while(k<n-1){
                List<int> tmpA = new List<int>();
                for(int i=0; i<n; i++){
                    if (k!=i){
                        tmpA.Add(a[i]);
                    }
                }
                int tmp = int.MinValue;
                for (int i=0; i<tmpA.Count-1; i++){
                    tmp = Math.Max(tmp, Math.Abs(tmpA[i] - tmpA[i+1]));
                }
                result = Math.Min(result, tmp);
                k++;
            }

            Console.WriteLine(result);
        }
    }
}
