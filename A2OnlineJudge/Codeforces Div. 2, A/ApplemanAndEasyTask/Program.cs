using System;

namespace ApplemanAndEasyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int [,] board = new int[n,n];

            for(int i=0; i<n; i++){
                string tmp = Console.ReadLine();
                for(int j=0; j<n; j++){
                    board[i,j] = (tmp[j] == 'o')?1:0;
                }
            }

            for (int i=0;i<n;i++){
                for(int j=0; j<n; j++){
                    int count = 0;
                    if (i>0){
                        count += board[i-1, j];
                    }
                    if(i<n-1){
                        count += board[i+1, j];
                    }
                    if(j>0){
                        count += board[i, j-1];
                    }
                    if(j<n-1){
                        count += board[i, j+1];
                    }

                    if (count % 2 == 1){
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
