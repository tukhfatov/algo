using System;

namespace Domino
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int [] x = new int[n];
            int [] y = new int[n];

            int xTotal = 0, yTotal = 0;
            for (int i = 0; i < n; i++)
            {
                string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);
                x[i] = int.Parse(input[0]);
                xTotal += x[i];
                y[i] = int.Parse(input[1]);
                yTotal += y[i];
            }

            if ( xTotal%2 == 0 && yTotal % 2 == 0){
                Console.WriteLine(0);
            }else{
                bool isExist = false;
                for (int i = 0; i < n; i++)
                {
                    if (x[i]%2==1 || y[i]%2==1){
                        xTotal = xTotal - x[i] + y[i];
                        yTotal = yTotal - y[i] + x[i];
                    }

                    if (xTotal%2 == 0 && yTotal%2 == 0){
                        isExist = true;
                        break;
                    }
                }
                Console.WriteLine(isExist? 1:-1);
                
            }
        }
    }
}
