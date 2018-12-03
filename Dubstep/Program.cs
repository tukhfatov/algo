using System;

namespace Dubstep
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string[] result = word.Split(new[] { "WUB" }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
