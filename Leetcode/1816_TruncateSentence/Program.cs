using System;

namespace _1816_TruncateSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TruncateSentence("Hello how are you Contestant", 4));
        }

        public static string TruncateSentence(string s, int k)
        {
            var a = s.Split(' ');
            StringBuilder r = new StringBuilder(k);
            for (int i = 0; i < k; i++)
            {
                r.Append(a[i] + " ");
            }

            return r.ToString().Trim();
        }
    }
}
