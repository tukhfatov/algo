using System;
using System.Collections.Generic;

namespace ValeraAndX
{
    class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());

            string input = "";
            for (int i=0; i<n; i++){
                input += Console.ReadLine();
            }
            List<char> alphas = new List<char>();
            for (int i=0; i<n*n; i++){
                if (!alphas.Contains(input[i])){
                    alphas.Add(input[i]);
                }
            }
            if (alphas.Count == 1){
                Console.WriteLine("NO");
                return;
            }

            List<char> diagonal = new List<char>();
            List<char> reverseDiagonal = new List<char>();
            
            for (int i=0; i<n; i++){
                if (!diagonal.Contains(input[i*n+i])){
                    diagonal.Add(input[i*n+i]);
                }
                if (!reverseDiagonal.Contains(input[(n*i+n-1) -i])){
                    reverseDiagonal.Add(input[(n*i+n-1) -i]);
                }

            }
            if (diagonal.Count > 1 || reverseDiagonal.Count > 1){
                Console.WriteLine("NO");
                return;
            }

            bool diff = false;
            for (int i=0; i<n/2; i++){
                if (!input.Substring(i*n, n).Equals(input.Substring((n-1-i)*n, n))){
                    diff = true;
                    break;
                }
            }

            bool middDiff = false;
            string middle = input.Substring((n*(n/2)), n);
            middDiff = !middle.Substring(0, n/2).Equals(middle.Substring(n/2+1, n/2));

            if (diff || middDiff){
                Console.WriteLine("NO");
                return;
            }
            Console.WriteLine("YES");
        }
    }
}
