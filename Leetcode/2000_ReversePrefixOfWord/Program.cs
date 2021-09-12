using System;

namespace _2000_ReversePrefixOfWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReversePrefix("abcdefd", 'd'));
            Console.WriteLine(ReversePrefix("xyxzxe", 'z'));
            Console.WriteLine(ReversePrefix("abcd", 'z'));
        }

        public static string ReversePrefix(string word, char ch)
        {
            int ind = word.IndexOf(ch);
            if (ind > 0)
            {
                string tmp = "";
                string sec = word.Substring(ind + 1);
                while (ind >= 0)
                {
                    tmp += word[ind];
                    ind--;
                }
                tmp = tmp + sec;
                return tmp;
            }

            return word;
        }
    }
}
