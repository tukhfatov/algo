using System;

namespace LunchRush
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            long k = long.Parse(input[1]);

            long result = long.MinValue;
            for (int i=0; i<n; i++){
                input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);
                long f = long.Parse(input[0]);
                long t = long.Parse(input[1]);

                result = Math.Max(result, (t>k)?f-(t-k): f);
            }
            Console.WriteLine(result);
        }
    }
}
