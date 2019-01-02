using System;

namespace CutRibbon
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int a = int.Parse(input[1]);
            int b = int.Parse(input[2]);
            int c = int.Parse(input[3]);

            int [] d = new int[n+1];
            for(int i=0; i<=n; i++){
                d[i] = -1;
            }

            d[0] = 0;

            for (int i=1; i<=n; i++){
                if (i-a >= 0 && d[i-a] != -1){
                    d[i] = Math.Max(d[i], d[i-a] +1);
                }
                if (i-b >= 0 && d[i-b] != -1){
                    d[i] = Math.Max(d[i], d[i-b] +1);
                }
                if (i-c >= 0 && d[i-c] != -1){
                    d[i] = Math.Max(d[i], d[i-c] +1);
                }
                // for(int j=0; j<=n; j++){
                //     Console.Write(d[j]+" ");
                // }
                // Console.WriteLine();
            }

            Console.WriteLine(d[n]);
        }
    }
}
