using System;

namespace Cakeminator
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int r = int.Parse(input[0]);
            int c = int.Parse(input[1]);

            string[] cake = new string[r];

            int count = 0;            
            for(int i=0; i<r; i++){
                string cakeInput = Console.ReadLine();
                if (cakeInput.IndexOf('S') == -1){
                    count+=cakeInput.Length;
                    cakeInput = new string(' ', cakeInput.Length);
                }
                cake[i] = cakeInput;
            }
            for(int i=0; i<c; i++){
                string tmp = "";
                int internalCount = 0;
                for(int j=0; j<r; j++){
                    tmp += cake[j][i];
                    if (cake[j][i] == '.'){
                        internalCount++;
                    }
                }
                if (tmp.IndexOf('S') == -1){
                    count += internalCount;
                }
            }
            Console.WriteLine(count);
        }
    }
}
