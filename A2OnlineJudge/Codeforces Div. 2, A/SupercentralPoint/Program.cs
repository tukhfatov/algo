using System;

namespace SupercentralPoint
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int [] x = new int[n];
            int [] y = new int[n];
            for (int i=0; i<n; i++){
                string [] input  = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);
                x[i] = int.Parse(input[0]);
                y[i] = int.Parse(input[1]);
            }

            int count = 0;
            for(int i=0; i<n; i++){
                bool hasTop = false, hasBottom = false, hasLeft = false, hasRight = false;
                for (int j=0; j<n; j++){
                    if (x[i]==x[j] && i!=j &&  y[i]<y[j]){
                        hasTop = true;
                    }
                    if (x[i]==x[j] && i!=j &&  y[i]>y[j]){
                        hasBottom = true;
                    }
                    if (x[i]>x[j] && i!=j &&  y[i]==y[j]){
                        hasLeft = true;
                    }
                    if (x[i]<x[j] && i!=j &&  y[i]==y[j]){
                        hasRight = true;
                    }
                }

                if (hasBottom && hasTop && hasLeft && hasRight){
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
