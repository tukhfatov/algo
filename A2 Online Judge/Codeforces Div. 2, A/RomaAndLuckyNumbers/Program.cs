using System;

namespace RomaAndLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            string [] a = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int result = 0;
            for(int i=0; i<n; i++){
                int count = 0;
                string tmp = a[i];

                for(int j=0; j<tmp.Length; j++){
                    if (tmp[j] == '4' || tmp[j] == '7'){
                        count++;
                    }
                }
                if (count <= k){
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
