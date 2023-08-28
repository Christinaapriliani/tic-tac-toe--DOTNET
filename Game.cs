using System;

namespace TicTacToeApp
{
    public class Game
    {
        private Board board;
        private char currentPlayer;

        public Game()
        {
            board = new Board();
            currentPlayer = 'X';
        }

        public void Play()
        {
            while (!board.IsGameOver())
            {
                board.Display();

                Console.WriteLine($"Player {currentPlayer}'s turn.");
                Console.Write("Enter row (0-2): ");
                int row = int.Parse(Console.ReadLine());

                Console.Write("Enter column (0-2): ");
                int col = int.Parse(Console.ReadLine());

                if (board.IsValidMove(row, col))
                {
                    board.MakeMove(row, col, currentPlayer);
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
                else
                {
                    Console.WriteLine("Invalid move! Try again.");
                }
            }

            board.Display();
            char winner = board.GetWinner();
            if (winner == ' ')
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine($"Player {winner} wins!");
            }
        }
    }
}
