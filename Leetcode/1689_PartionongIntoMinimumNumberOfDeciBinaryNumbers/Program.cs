using System;

namespace _1689_PartionongIntoMinimumNumberOfDeciBinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinPartitions("32"));
            Console.WriteLine(MinPartitions("82734"));
            Console.WriteLine(MinPartitions("27346209830709182346"));
        }
        public static int MinPartitions(string n)
        {
            int m = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (Convert.ToInt32(n[i] - '0') > m)
                {
                    m = Convert.ToInt32(n[i] - '0');
                }
            }

            return m;
        }
    }
}
