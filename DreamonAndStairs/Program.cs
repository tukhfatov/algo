using System;

namespace DreamonAndStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int countTwo = n/2;
            int countOne = n%2;

            if ( (countOne + countTwo) % m == 0){
                Console.WriteLine(countOne+countTwo);
            }else{
                bool found = false;
                while (countTwo>0)
                {
                    countTwo--;
                    countOne += 2;
                    if ((countOne + countTwo) % m == 0) {
                        found = true;
                        break;
                    }
                }
                Console.WriteLine((found) ? countOne+countTwo : -1);
            }
       }
    }
}
