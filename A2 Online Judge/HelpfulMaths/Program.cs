using System;

namespace HelpfulMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] exp = input.Split(new char[] { '+' }, StringSplitOptions.None);

            Array.Sort(exp);
            Console.WriteLine(string.Join("+", exp));
        }
    }
}
