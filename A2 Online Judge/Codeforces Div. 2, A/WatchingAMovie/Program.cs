using System;

namespace WatchingAMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int x = int.Parse(input[1]);

            int [] l = new int[n];
            int [] r = new int[n];

            for(int i=0; i<n; i++){
                string [] moments = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);
                l[i] =int.Parse(moments[0]);
                r[i] =int.Parse(moments[1]);
            }

            int cursor = 1;
            int result = 0;
            for (int i=0; i<n; i++){
                while(true){
                    if (cursor+x > l[i]){
                        break;
                    }
                    cursor+=x;
                }
                result += (r[i] - cursor + 1);
                cursor = r[i] +1;

            }
            Console.WriteLine(result);
        }
    }
}
