using System;

namespace ColorfulStones
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            int cursor = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (s[cursor] == t[i]){
                    cursor++;
                }
            }
            Console.WriteLine(cursor+1);
        }
    }
}
