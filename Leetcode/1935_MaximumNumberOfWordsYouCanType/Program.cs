using System;

namespace _1935_MaximumNumberOfWordsYouCanType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanBeTypedWords("hello world", "ad"));
            Console.WriteLine(CanBeTypedWords("leet code", "lt"));
            Console.WriteLine(CanBeTypedWords("leet code", "e"));
        }

        public static int CanBeTypedWords(string text, string brokenLetters)
        {
            int count = 0;
            var words = text.Split();

            foreach (var word in words)
            {
                count++;
                foreach (var l in word)
                {
                    if (brokenLetters.Contains(l))
                    {
                        count--;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
