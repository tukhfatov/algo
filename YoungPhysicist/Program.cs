using System;

namespace YoungPhysicist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int x=0, y=0, z=0;

            for (int i = 0; i < n;i++){
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.None);

                x += int.Parse(input[0]);
                y += int.Parse(input[1]);
                z += int.Parse(input[2]);
            }

            if (x!=0 || y!=0 || z!=0){
                Console.WriteLine("NO");
            }else{
                Console.WriteLine("YES");
            }
        }
    }
}
