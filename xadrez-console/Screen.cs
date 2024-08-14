using board;
using chess;

namespace xadrez_console
{
    class Screen
    {
        public static void PrintBoard(Board board)
        {
            for (int x = 0; x < board.Lines; x++)
            {
                Console.Write(8 - x + " ");
                for (int y = 0; y < board.Columns; y++)
                {
                    if (board.Piece(x, y) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(board.Piece(x, y));
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static PositionChess ReadPositionChess()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new PositionChess(column, line);
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.white)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
