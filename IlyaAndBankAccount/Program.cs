using System;

namespace IlyaAndBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long n = long.Parse(input);

            if (n>0){
                Console.WriteLine(n);
            }else{
                long last = n / 10;
                n *= -1;
                long beforeLast = long.Parse((n / 100).ToString() + input[input.Length - 1].ToString());
                beforeLast *= -1;
                Console.WriteLine(Math.Max(beforeLast, last));
            }
        }
    }
}