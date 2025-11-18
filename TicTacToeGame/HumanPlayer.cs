using System;

namespace TicTacToeGame
{
    // HumanPlayer inherits from PlayerBase
    public class HumanPlayer : PlayerBase
    {
        public HumanPlayer(char mark) : base(mark)
        {
        }

        // Ask the user for a move and validate input
        public override int GetMove(char[] board)
        {
            while (true)
            {
                Console.Write($"Player {Symbol}, enter your move (1-9): ");
                string? input = Console.ReadLine(); // could be null

                // Check for null or empty input
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please enter a number 1-9.");
                    continue;
                }

                // Try parsing input to integer
                if (int.TryParse(input, out int move))
                {
                    if (move >= 1 && move <= 9)
                    {
                        // Ensure the chosen cell is free before returning
                        if (board[move - 1] == 'X' || board[move - 1] == 'O')
                        {
                            Console.WriteLine("That cell is already taken. Choose another.");
                        }
                        else
                        {
                            return move;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid move. Enter a number between 1 and 9.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
        }
    }
}