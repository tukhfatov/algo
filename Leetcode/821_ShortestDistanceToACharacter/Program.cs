using System.Collections.Generic;
using System;

namespace _821_ShortestDistanceToACharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", ShortestToChar("loveleetcode", 'e')));
            Console.WriteLine(string.Join(" ", ShortestToChar("aaab", 'b')));
        }

        public static int[] ShortestToChar(string s, char c)
        {
            var l = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    l.Add(i);
                    //Console.WriteLine(i);
                }
            }
            int[] r = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    r[i] = 0;
                }
                else
                {
                    int m = Int32.MaxValue;
                    for (int j = 0; j < l.Count; j++)
                    {
                        //Console.WriteLine("Calc: " + l[j] + "  " + i + " " + Math.Abs(l[j] - i));
                        m = Math.Min(m, Math.Abs(i - l[j]));
                    }
                    //Console.WriteLine("Min: " + m);
                    r[i] = m;
                }
            }

            return r;
        }
    }
}
