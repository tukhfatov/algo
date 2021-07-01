using System;

namespace _1812_DetermineColorOfAChessboardSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareIsWhite("a1"));
            Console.WriteLine(SquareIsWhite("h3"));
            Console.WriteLine(SquareIsWhite("c7"));
        }

        public static bool SquareIsWhite(string coordinates)
        {
            string cols = "abcdefgh";

            int col = cols.IndexOf(coordinates[0]) + 1;
            int row = Convert.ToInt32(coordinates[1]);

            if ((col + row) % 2 == 0)
            {
                return false;
            }

            return true;

        }
    }
}
