using System;

namespace TicTacToeApp
{
    public class Board
    {
        private char[,] cells;
        private int moves;

        public Board()
        {
            cells = new char[3, 3];
            Clear();
        }

        public void Clear()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    cells[row, col] = ' ';
                }
            }
            moves = 0;
        }

        public bool IsValidMove(int row, int col)
        {
            return cells[row, col] == ' ';
        }

        public void MakeMove(int row, int col, char player)
        {
            cells[row, col] = player;
            moves++;
        }

        public bool IsGameOver()
        {
            return moves == 9 || GetWinner() != ' ';
        }

        public char GetWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (cells[i, 0] != ' ' && cells[i, 0] == cells[i, 1] && cells[i, 0] == cells[i, 2])
                {
                    return cells[i, 0];
                }
                if (cells[0, i] != ' ' && cells[0, i] == cells[1, i] && cells[0, i] == cells[2, i])
                {
                    return cells[0, i];
                }
            }

            if (cells[0, 0] != ' ' && cells[0, 0] == cells[1, 1] && cells[0, 0] == cells[2, 2])
            {
                return cells[0, 0];
            }

            if (cells[0, 2] != ' ' && cells[0, 2] == cells[1, 1] && cells[0, 2] == cells[2, 0])
            {
                return cells[0, 2];
            }

            return ' ';
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("     0   1   2");
            Console.WriteLine("   +---+---+---+---+");
            for (int row = 0; row < 3; row++)
            {
                Console.Write($" {row} |");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($" {cells[row, col]} |");
                }
                Console.WriteLine("\n   +---+---+---+---+");
            }
        }
    }
}
