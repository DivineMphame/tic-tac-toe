using System.IO;

namespace TicTacToeGame
{
    public static class SaveSystem
    {
        private const string FileName = "save.txt";

        // Writes the board to a file
        public static void Save(char[] board)
        {
            File.WriteAllText(FileName, new string(board));
        }

        // Reads the board from a file
        public static char[] Load()
        {
            if (!File.Exists(FileName))
                return new char[9] {'1','2','3','4','5','6','7','8','9'}; // Return empty board if no save file exists

            return File.ReadAllText(FileName).ToCharArray();
        }
    }
}