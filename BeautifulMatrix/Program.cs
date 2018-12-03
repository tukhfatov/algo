using System;

namespace BeautifulMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int posX = 0, posY = 0;
            for (int i = 0; i < 5; i++){
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);
                for (int j = 0; j < input.Length; j++){
                    if (input[j] == "1"){
                        posX = j;
                        posY = i;
                    }
                }
            }

            Console.WriteLine(Math.Abs(posX - 2) + Math.Abs(posY - 2));
        }
    }
}
