using System;

namespace _1941_CheckIfAllCharactersHaveEqualNumberOfOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreOccurrencesEqual("abacbc"));
            Console.WriteLine(AreOccurrencesEqual("aaabb"));
            Console.WriteLine(AreOccurrencesEqual("vvvvvvvvvvvvvvvvvvv"));
        }

        public static bool AreOccurrencesEqual(string s)
        {
            int[] a = new int[26];

            foreach (char i in s)
            {
                a[i - 'a']++;
            }
            int m = 0;
            for (int i = 0; i < 26; i++)
            {
                m = Math.Max(a[i], m);
            }
            for (int i = 0; i < 26; i++)
            {
                if (a[i] > 0 && m != a[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
