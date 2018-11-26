using System;

namespace Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            long w = long.Parse(Console.ReadLine());
            if (w > 2)
            {
                Console.WriteLine((w % 2 == 1) ? "NO" : "YES");
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}
