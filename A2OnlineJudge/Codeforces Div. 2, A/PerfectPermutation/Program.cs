using System;

namespace PerfectPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int [] p = new int[n];

            for(int i=0; i<n; i++){
                p[i] = i+1;
            }

            for(int i=0; i<n-1; i+=2){
                int tmp = p[i];
                p[i] = p[i+1];
                p[i+1] = tmp;
            }

            for(int i=0; i<n; i++){
                if(p[i] == (i+1)){
                    Console.WriteLine(-1);
                    return;
                }
            }
            
            for(int i=0; i<n; i++){
                Console.Write(p[i]+" ");
            }

        
        }
    }
}
