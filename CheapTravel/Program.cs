using System;

namespace CheapTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input  = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int a = int.Parse(input[2]);
            int b = int.Parse(input[3]);

            long f1 = n * a;

            int i=0;
            long f2 = 0;
            while(i<=n){
                if (i+m > n){
                    break;
                }
                f2 += b;
                i+= m;
            }
            f2 += (n-i) * a;

            i=0;
            long f3 = 0;
            while(i<=n){
                f3 += b;
                i+= m;
            }

            Console.WriteLine(Math.Min(Math.Min(f1, f2), f3));
            
        }
    }
}