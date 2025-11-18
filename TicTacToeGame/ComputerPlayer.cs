using System;

namespace TicTacToeGame
{
    public class ComputerPlayer : PlayerBase
    {
        private Random rng = new Random();

        public ComputerPlayer(char symbol) : base(symbol) {}

        public override int GetMove(char[] board)
        {
            // Picks a random available spot
            int move;
            do
            {
                move = rng.Next(1, 10);
            }
            while (board[move - 1] == 'X' || board[move - 1] == 'O');

            Console.WriteLine($"Computer chooses {move}");
            return move;
        }
    }
}