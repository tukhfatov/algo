using System.Linq;
using System.Collections.Generic;
using System;

namespace _1337_TheKWeakestRowsInAMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", KWeakestRows(new int[][]{
                new int[]{
                    1,1,0,0,0
                },
                new int[]{
                    1,1,1,1,0
                },
                new int[]{
                    1,0,0,0,0
                },
                new int[]{
                    1,1,0,0,0
                },
                new int[]{
                    1,1,1,1,1
                }
            }, 3)));

            Console.WriteLine(String.Join(" ", KWeakestRows(new int[][]{
                new int[]{
                   1,0,0,0
                },
                new int[]{
                    1,1,1,1
                },
                new int[]{
                    1,0,0,0
                },
                new int[]{
                    1,1,0,0
                },
            }, 2)));

            Console.WriteLine(String.Join(" ", KWeakestRows(new int[][]{
                new int[]{
                    1,1,1,1,1,1
                },
                new int[]{
                    1,1,1,1,1,1
                },
                new int[]{
                    1,1,1,1,1,1
                }
            }, 1)));

        }

        public static int[] KWeakestRows(int[][] mat, int k)
        {
            Dictionary<int, int> a = new Dictionary<int, int>();

            for (int i = 0; i < mat.Length; i++)
            {
                int c = 0;
                foreach (int j in mat[i])
                {
                    if (j == 1) c++;
                }
                a[i] = c;
            }
            int[] res = new int[k];
            int q = 0;
            foreach (var item in a.OrderBy(x => x.Value).Take(k))
            {
                res[q++] = item.Key;
            }
            return res;
        }
    }
}
