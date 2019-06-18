using System;

namespace PashmakAndGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

            int x1 = int.Parse(input[0]);
            int y1 = int.Parse(input[1]);
            int x2 = int.Parse(input[2]);
            int y2 = int.Parse(input[3]);

            int difX = Math.Abs(x1 - x2);
            int difY = Math.Abs(y1 - y2);

            if (difX == 0)
            {
                int x3 = x1 + difY;
                int y3 = y1;

                int x4 = x3;
                int y4 = y2;
                Console.WriteLine(x3 + " " + y3 + " " + x4 + " " + y4);
            }
            else if (difY == 0)
            {
                int x3 = x1;
                int y3 = y1 + difX;

                int x4 = x2;
                int y4 = y2 + difX;

                Console.WriteLine(x3 + " " + y3 + " " + x4 + " " + y4);
            }
            else
            {
                if (difX == difY)
                {
                    int x3 = x1;
                    int y3 = y2;

                    int x4 = x2;
                    int y4 = y1;

                    Console.WriteLine(x3 + " " + y3 + " " + x4 + " " + y4);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
