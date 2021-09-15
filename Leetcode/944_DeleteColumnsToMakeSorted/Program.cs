using System;

namespace _944_DeleteColumnsToMakeSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinDeletionSize(new string[] {
                "cba","daf","ghi"
            }));
            Console.WriteLine(MinDeletionSize(new string[] {
                "a", "b"
            }));
            Console.WriteLine(MinDeletionSize(new string[] {
                "zyx","wvu","tsr"
            }));

            Console.WriteLine(MinDeletionSize(new string[] {
                "rrjk","furt","guzm"
            }));
        }

        public static int MinDeletionSize(string[] strs)
        {
            int res = 0;
            int cn = strs[0].Length;
            for (int j = 0; j < cn; j++)
            {
                for (int i = 0; i < strs.Length - 1; i++)
                {
                    if (strs[i][j] > strs[i + 1][j])
                    {
                        res++;
                        break;
                    }

                }
            }

            return res;
        }
    }
}
