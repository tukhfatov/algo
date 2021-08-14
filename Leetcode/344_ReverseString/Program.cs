using System;

namespace _344_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
            ReverseString(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' });
        }

        public static void ReverseString(char[] s)
        {

            int j = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                char tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;
                j--;
            }

            foreach (var i in s)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();

        }
    }
}
