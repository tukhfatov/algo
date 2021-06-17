using System;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(1));
        }
        public static int Fib(int N)
        {
            var i = 1;
            var a = 0;
            var b = 1;
            if (N == 1)
            {
                return b;
            }
            var result = 0;
            while (i < N)
            {
                result = a + b;
                a = b;
                b = result;
                i++;
            }
            return result;
        }
    }
}