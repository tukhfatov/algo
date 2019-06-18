using System;

namespace IWannaBeTheGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] inputX = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);
            string[] inputY = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

            bool[] a = new bool[n];

            for (int i = 0; i < n;i++){
                a[i] = false;
            }

            for (int i = 0; i < int.Parse(inputX[0]); i++){
                int l = int.Parse(inputX[i + 1]);
                a[l - 1] = true;
            }
            for (int i = 0; i < int.Parse(inputY[0]); i++)
            {
                int l = int.Parse(inputY[i + 1]);
                a[l - 1] = true;
            }

            bool result = true;

            for (int i = 0; i < n; i++){
                if (!a[i]){
                    result = false;
                    break;
                }
            }

            if (result){
                Console.WriteLine("I become the guy.");
            }else{
                Console.WriteLine("Oh, my keyboard!");
            }
        }
    }
}
