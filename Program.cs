using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] ticTacToeBoard =
            {
                {'-', '-', '-' },
                {'-', '-', '-' },
                {'-', '-', '-' },
            };
            for (int turns = 0; turns < 9; turns++)
            {
                //Player X
                Console.Write("Player 'X', Row: ?");
                int rX = int.Parse(Console.ReadLine());
                Console.Write("Player 'X', Column: ?");
                int cX = int.Parse(Console.ReadLine());

                ticTacToeBoard[rX, cX] = 'X';

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        Console.Write(ticTacToeBoard[row, col]);
                    }
                    Console.WriteLine();
                }
                //Player O
                Console.Write("Player 'O', Row: ?");
                int rO = int.Parse(Console.ReadLine());
                Console.Write("Player 'O', Column: ?");
                int cO = int.Parse(Console.ReadLine());

                ticTacToeBoard[rO, cO] = 'O';

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        Console.Write(ticTacToeBoard[row, col]);
                    }
                    Console.WriteLine();
                }
            }//end of main
        }
    }
}
