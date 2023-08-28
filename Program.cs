using System;

namespace TicTacToeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("Player 1: X, Player 2: O");

            Game game = new Game();
            game.Play();
        }
    }
}
