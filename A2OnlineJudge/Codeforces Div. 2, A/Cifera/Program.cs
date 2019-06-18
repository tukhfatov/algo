using System;

namespace Cifera {
    class Program {
        static void Main (string[] args) {
            int k = int.Parse (Console.ReadLine ());
            int l = int.Parse (Console.ReadLine ());

            int count = 0;
            while (l % k == 0 && l != 1) {
                l = l / k;
                count++;
            }

            if (l == 1) {
                Console.WriteLine ("YES");
                Console.WriteLine (count - 1);
            } else {
                Console.WriteLine ("NO");
            }
        }
    }
}