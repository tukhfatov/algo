using System;

namespace FoxAndSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int t = m-1;
            for (int i=0; i<n;i++){
                for(int j=0; j<m; j++){
                    if (i%2 == 0){
                        Console.Write("#");
                    }else{
                        Console.Write( (j == t) ? '#': '.');
                    }
                }
                if (i%2==1){
                    t = (t==0) ? m-1: 0;
                }
                Console.WriteLine();
            }
        }
    }
}
