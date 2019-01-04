using System;
using System.Collections.Generic;

namespace Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            string [] marks = new string[n];

            for (int i=0; i<n; i++){
                marks[i] = Console.ReadLine();
            }

            var studentIndex = new List<int>();
            var isSame = false;
            for(int i=0; i<m; i++){
                var max = int.MinValue;
                var min = int.MaxValue;
                var tmp = new List<int>();
                for(int j=0; j<n; j++){
                    var mark = int.Parse(marks[j][i].ToString());
                    tmp.Add(mark);
                    max = Math.Max(mark, max);
                    min = Math.Min(mark, min);
                }
                if (studentIndex.IndexOf(tmp.IndexOf(max)+1) == -1){
                    studentIndex.Add(tmp.IndexOf(max)+1);
                }

                if (max - min == 0){   
                    isSame = true;                
                    break;
                }                
            }

            Console.WriteLine(isSame ? n : studentIndex.Count);
        }
    }
}
