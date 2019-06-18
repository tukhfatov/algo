using System;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            long max = long.MinValue;
            long exp0 = a + b + c;
            if (exp0 > max){
                max = exp0;
            }
            long exp1 = a + b * c;
            if (exp1 > max){
                max = exp1;
            }
            long exp2 = a * (b + c);
            if (exp2 > max) {
                max = exp2;
            }
            long exp3 = a * b * c;
            if (exp3>max){
                max = exp3;
            }
            long exp4 = (a + b) * c;
            if (exp4 > max){
                max = exp4;
            }
            long exp5 = a * b + c;
            if (exp5 > max){
                max = exp5;
            }
            Console.WriteLine(max);
        }
    }
}
