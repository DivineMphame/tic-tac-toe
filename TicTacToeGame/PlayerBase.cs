namespace TicTacToeGame
{
    // Abstract parent class using inheritance
    public abstract class PlayerBase
    {
        public char Symbol { get; }

        public PlayerBase(char symbol)
        {
            Symbol = symbol;
        }

        //This  MUST be overridden
        public abstract int GetMove(char[] board);
    }
}