using System;

namespace LuckyDivision
{
    class Program
    {
        static bool ContainsLucky(string n)
        {
            bool result = true;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] != '4' && n[i] != '7')
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            string n = Console.ReadLine();
            if (int.Parse(n) % 4 == 0 || int.Parse(n) % 7 == 0 || int.Parse(n) % 47 == 0 || ContainsLucky(n))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
