using System;

namespace GameWithSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int min = n > m ? m : n;

            if (min % 2 ==1 ){
                Console.WriteLine("Akshat");
            }else{
                Console.WriteLine("Malvika");
            }
        }
    }
}
