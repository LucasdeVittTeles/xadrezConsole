using board;

namespace xadrez_console
{
    class Screen
    {
        public static void PrintBoard(Board board)
        {
            for (int x = 0; x < board.Lines; x++)
            {
                for (int y = 0; y < board.Columns; y++)
                {
                    if (board.Piece(x, y) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.Piece(x, y) + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
