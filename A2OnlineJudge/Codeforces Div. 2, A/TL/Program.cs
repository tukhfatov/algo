using System;

namespace TL
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            string [] a =  Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);
            string [] b =  Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int maxRightIndex = int.MinValue;
            int minRightIndex = int.MaxValue;
            for(int i=0; i<n; i++){
                int index = int.Parse(a[i]);
                maxRightIndex = Math.Max(maxRightIndex, index);
                minRightIndex = Math.Min(minRightIndex, index);
            }
            int v = maxRightIndex / minRightIndex >= 2 ? maxRightIndex : minRightIndex * 2;
            
            bool vLower = false;
            for(int i=0; i<m; i++){
                int wrongAnswer = int.Parse(b[i]);
                if (wrongAnswer <= v){
                    vLower = true;
                    break;
                }
            }

            if (vLower){
                Console.WriteLine(-1);
                return;
            }else{
                Console.WriteLine(v);
            }
        }
    }
}
