using System;

namespace TicTacToeGame
{
    public class Game
    {
        private Board board;
        private PlayerBase playerX;
        private PlayerBase playerO;

        public Game()
        {
            board = new Board();
            playerX = new HumanPlayer('X');  // inheritance
            playerO = new ComputerPlayer('O'); // inheritance
        }

        public void Start()
        {
            char currentPlayer = 'X';
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Tic Tac Toe ===\n");
                board.Display();

                PlayerBase active =
                    currentPlayer == 'X' ? playerX : playerO;

                int move = active.GetMove(board.Cells);

                if (board.IsCellFree(move))
                {
                    board.PlaceMark(move, currentPlayer);
                    SaveSystem.Save(board.Cells);

                    if (board.CheckWin(currentPlayer))
                    {
                        Console.Clear();
                        board.Display();
                        Console.WriteLine($"\nPlayer {currentPlayer} wins!");
                        running = false;
                    }
                    else if (board.IsDraw())
                    {
                        Console.Clear();
                        board.Display();
                        Console.WriteLine("\nIt's a draw!");
                        running = false;
                    }
                    else
                    {
                        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Cell taken. Press any key...");
                    Console.ReadKey();
                }
            }
        }
    }
}