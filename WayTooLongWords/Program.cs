using System;

namespace WayTooLongWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++){
                string input = Console.ReadLine();
                if (input.Length > 10){
                    int length = input.Length - 2;
                    Console.WriteLine(input[0] + length.ToString() + input[input.Length - 1]);
                }else{
                    Console.WriteLine(input);
                }
            }
        }
    }
}
