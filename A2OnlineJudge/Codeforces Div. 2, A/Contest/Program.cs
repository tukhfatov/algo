using System;

namespace Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);

            int Misha = Math.Max(3*a/10, a - a/250 *c);
            int Vasya = Math.Max(3*b/10, b - b/250 *d);

            if (Misha == Vasya){
                Console.WriteLine("Tie");
            }else if(Misha > Vasya){
                Console.WriteLine("Misha");
            }else{
                Console.WriteLine("Vasya");
            }
        }
    }
}
