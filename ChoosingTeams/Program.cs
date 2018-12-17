using System;

namespace ChoosingTeams
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            string [] teams = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.None);

            int count = 0;

            for (int i=0; i<n; i++){
                if(int.Parse(teams[i])+k <= 5){
                    count++;
                }
            }
            Console.WriteLine(count/3);
        }
    }
}
