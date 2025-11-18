using System;

namespace TicTacToeGame
{
    public class Board
    {
        public char[] Cells = new char[9];

        public Board()
        {
            for (int i = 0; i < 9; i++)
                Cells[i] = (char)('1' + i);  // variables + loop
        }

        public void Display()
        {
            Console.WriteLine($"{Cells[0]} | {Cells[1]} | {Cells[2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{Cells[3]} | {Cells[4]} | {Cells[5]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{Cells[6]} | {Cells[7]} | {Cells[8]}");
        }

        public bool IsCellFree(int pos)
        {
            return Cells[pos - 1] != 'X' && Cells[pos - 1] != 'O';
        }

        public void PlaceMark(int pos, char mark)
        {
            Cells[pos - 1] = mark;
        }

        public bool CheckWin(char mark)
        {
            int[,] wins = new int[,]
            {
                {0,1,2}, {3,4,5}, {6,7,8}, // rows
                {0,3,6}, {1,4,7}, {2,5,8}, // columns
                {0,4,8}, {2,4,6}           // diagonals
            };

            for (int i = 0; i < 8; i++)
            {
                if (Cells[wins[i, 0]] == mark &&
                    Cells[wins[i, 1]] == mark &&
                    Cells[wins[i, 2]] == mark)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsDraw()
        {
            foreach (char c in Cells)
                if (c != 'X' && c != 'O')
                    return false;

            return true;
        }
    }
}