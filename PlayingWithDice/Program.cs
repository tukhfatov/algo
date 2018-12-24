using System;

namespace PlayingWithDice
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int countA = 0, countB = 0, countTie = 0;
            for (int i=1; i<=6; i++){
                if ( Math.Abs(a-i) < Math.Abs(b-i)){
                    countA++;
                }
                if ( Math.Abs(a-i) > Math.Abs(b-i)){
                    countB++;
                }
                if ( Math.Abs(a-i) == Math.Abs(b-i)){
                    countTie++;
                }
            }

            Console.WriteLine(countA+" "+countTie+" "+countB);
        }
    }
}
