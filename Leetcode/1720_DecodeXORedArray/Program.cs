using System;

namespace _1720_DecodeXORedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Decode(new int[] { 1, 2, 3 }, 1);
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] Decode(int[] encoded, int first)
        {
            int[] res = new int[encoded.Length + 1];

            res[0] = first;
            for (int i = 1; i < res.Length; i++)
            {
                res[i] = res[i - 1] ^ encoded[i - 1];
            }
            return res;
        }
    }
}
