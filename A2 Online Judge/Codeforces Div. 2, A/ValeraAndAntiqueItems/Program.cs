using System;
using System.Collections.Generic;

namespace ValeraAndAntiqueItems
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            long v = long.Parse(input[1]);

            List<int> p = new List<int>();
            for(int i=0; i<n; i++){
                input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);
                for (int j=1; j<input.Length; j++){
                    if (long.Parse(input[j]) < v){
                        p.Add(i+1);
                        break;
                    }
                }
            }
            p.Sort();
            
            Console.WriteLine(p.Count);
            for(int i=0; i<p.Count; i++){
                Console.Write(p[i]+" ");
            }

        }
    }
}
