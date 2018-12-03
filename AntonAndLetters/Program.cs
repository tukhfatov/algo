using System;

namespace AntonAndLetters
{
    class Program
    {
        static void Main(string[] args)
        {
			string input = Console.ReadLine();

            string withoutBrackets = input.Substring(1, input.Length - 2);

            string[] a = withoutBrackets.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] counter = new int[150];
            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] = 0;
            }
            for (int i = 0; i < a.Length; i++){
                int index = (int)a[i].Trim()[0];
                counter[index]++;
            }
            int count = 0;
            for (int i = 0; i < counter.Length; i++){
                if(counter[i] > 0){
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
