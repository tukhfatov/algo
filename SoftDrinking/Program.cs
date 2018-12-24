using System;

namespace SoftDrinking
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int l = int.Parse(input[2]);
            int c = int.Parse(input[3]);
            int d = int.Parse(input[4]);
            int p = int.Parse(input[5]);
            int nl = int.Parse(input[6]);
            int np = int.Parse(input[7]);

            Console.WriteLine( Math.Min(Math.Min((k*l)/nl, c*d), p/np) / n);
        }
    }
}
