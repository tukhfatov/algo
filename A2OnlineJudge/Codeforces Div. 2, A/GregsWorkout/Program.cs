using System;

namespace GregsWorkout
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int [] train = new int[3];
            for (int i=0; i<n; i++){
                train[i%3] += int.Parse(input[i]);
            }

            int max = int.MinValue;
            int maxIndex = 0;
            for (int i=0; i<3; i++){
                if (train[i] > max){
                    max = train[i];
                    maxIndex = i;
                }
            }

            switch(maxIndex){
                case 0:
                    Console.WriteLine("chest");
                    break;
                case 1:
                    Console.WriteLine("biceps");
                    break;
                case 2:
                    Console.WriteLine("back");
                    break;
            }
        }
    }
}
