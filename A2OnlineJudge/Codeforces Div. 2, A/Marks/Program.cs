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
            int [] subjects = new int[m];

            int [] students = new int[n];

            for (int i=0; i<n; i++){
                string inp = Console.ReadLine();
                marks[i] = inp;
                students[i] = 0;
                for(int j=0; j<m; j++){
                    subjects[j] = Math.Max(subjects[j], int.Parse(inp[j].ToString()));                    
                }
            }
        
            for (int i = 0; i < n; i++)
            {
                string mark = marks[i];
                for (int j = 0; j < m; j++)
                {
                    if (subjects[j] == int.Parse(mark[j].ToString())){
                        students[i] = 1;
                        break;
                    }                    
                }
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (students[i] == 1) count++;
            }
            Console.WriteLine(count);
        }
    }
}
