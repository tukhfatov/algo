using System;
using System.Collections.Generic;

namespace TeamOlympiad
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string [] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.None);

            List<int> arrayMath = new List<int>();
            List<int> arrayProg = new List<int>();
            List<int> arrayPe = new List<int>();

            for (int i=0; i<n;i++){
                switch(int.Parse(input[i])){
                    case 1:
                        arrayProg.Add(i+1);
                        break;
                    case 2:
                        arrayMath.Add(i+1);
                        break;
                    case 3:
                        arrayPe.Add(i+1);
                        break;
                }
            }
            int minSize = Math.Min(Math.Min(arrayMath.Count, arrayProg.Count), arrayPe.Count);
            Console.WriteLine(minSize);

            for(int i=0;i<minSize; i++){
                Console.WriteLine(string.Format("{0} {1} {2}", arrayMath[i], arrayProg[i], arrayPe[i]));
            }

        }
    }
}
