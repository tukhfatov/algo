using System;

namespace Counterexample
{
    class Program
    {
        private static long gcd(long a, long b){
            if (b==0){
                return a;
            }
            return gcd(b, a%b);
        }

        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.None);

            long l = long.Parse(input[0]);
            long r = long.Parse(input[1]);

            long a = l, b=0, c=0;
            bool foundB = false, foundC = false;


            long i = l;

            while(i<=r){
                if (foundC){
                    break;
                }

                a = i;
                long j = a;
                while(j<= r){
                    if (gcd(a, j) ==1){
                        b = j;
                        foundB = true;
                        break;
                    }                
                    j++;
                }
                if (foundB){
                    long k = b;
                    while( k<= r){
                        if (gcd(b, k) == 1 && gcd(a, k) > 1){
                            c = k;
                            foundC = true;
                            break;
                        }                
                        k++;
                    }
                }
                i++;
            }

            if (foundB && foundC){
                Console.WriteLine(a+" "+b+" "+c);
            }else{
                Console.WriteLine(-1);
            }
        }
    }
}
