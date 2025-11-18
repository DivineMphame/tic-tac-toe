namespace TicTacToeGame
{
    // Simple struct demonstrating structs requirement
    public struct MoveRecord
    {
        public int Position;
        public char PlayerSymbol;

        public MoveRecord(int pos, char symbol)
        {
            Position = pos;
            PlayerSymbol = symbol;
        }
    }
}