using System;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());

            int[] h = new int[n];
            int[] a = new int[n];
            for (int i = 0; i < n; i++){
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);
                h[i] = int.Parse(input[0]);
                a[i] = int.Parse(input[1]);
            }
            int counter = 0;
            for (int i = 0; i < n;i++){
                for (int j = 0; j < n;j++){
                    if (h[i] == a[j] && i!=j){
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
