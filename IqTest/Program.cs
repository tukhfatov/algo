using System;

namespace IqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string [] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.None);

            int countOdd = 0, countEven = 0, oddIndex = 0, evenIndex = 0;
            for (int i =0; i<n; i++){
                int k = int.Parse(input[i]);
                if (k%2 == 0){
                    countEven++;
                    if (countEven == 1){
                        evenIndex = i+1;
                    }else{
                        evenIndex = 0;
                    }
                }else{
                    countOdd++;
                    if (countOdd == 1){
                        oddIndex = i+1;
                    }else{
                        oddIndex = 0;
                    }
                }
            }
            Console.WriteLine((oddIndex > 0)?oddIndex:evenIndex);
        }
    }
}
