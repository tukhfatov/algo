using System;

namespace DevuTheSingerAndChuruTheJoker
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int d = int.Parse(input[1]);

            string [] songInput = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int [] t = new int[n];

            long total = 0;
            long count = 0;
            for (int i=0; i<n; i++){
                total += int.Parse(songInput[i]);
                if (i < n-1){
                    total += 10;
                    count+=2;
                }
            }
            if (total <= d){
                count += (d-total)/5;
            }else{
                count = -1;
            }
            Console.WriteLine(count);
        }
    }
}
