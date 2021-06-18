using System.Collections.Generic;
using System;

namespace _1656_DesignAnOrderedStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    public class OrderedStream
    {

        private int cur;
        private int total;
        private Dictionary<int, string> dict;


        public OrderedStream(int n)
        {
            dict = new Dictionary<int, string>(n);
            total = n;
            cur = 1;
        }

        public IList<string> Insert(int idKey, string value)
        {
            dict.Add(idKey, value);
            var res = new List<string>();
            for (int i = cur; i <= total; i++)
            {
                if (dict.ContainsKey(i))
                {
                    cur = i + 1;
                    res.Add(dict[i]);
                }
                else
                {
                    break;
                }
            }

            return res;
        }
    }

}
