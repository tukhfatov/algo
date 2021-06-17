using System;

namespace AvailableCapturesForRook
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[][] {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', 'p', 'R', '.', '.', '.', 'p' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            var result = NumRookCaptures(board);
            Console.WriteLine(result);
        }
        public static int NumRookCaptures(char[][] board)
        {
            int x = 0;
            int y = 0;
            bool found = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        x = i;
                        y = j;
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }
            int count = 0;
            for (int i = x; i < 8; i++)
            {
                if (board[x][i] == 'p')
                {
                    count++;
                    break;
                }
                if (board[x][i] == 'B')
                {
                    break;
                }
            }
            for (int i = x; i >= 0; i--)
            {
                if (board[x][i] == 'p')
                {
                    count++;
                    break;
                }
                if (board[x][i] == 'B')
                {
                    break;
                }
            }

            for (int i = y; i < 8; i++)
            {
                if (board[i][y] == 'p')
                {
                    count++;
                    break;
                }
                if (board[i][y] == 'B')
                {
                    break;
                }
            }
            for (int i = y; i >= 0; i--)
            {
                if (board[i][y] == 'p')
                {
                    count++;
                    break;
                }
                if (board[i][y] == 'B')
                {
                    break;
                }
            }

            return count;
        }
    }

}