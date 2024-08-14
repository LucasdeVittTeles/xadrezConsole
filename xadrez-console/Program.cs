using board;
using chess;

namespace xadrez_console
{
    class Program
    {
        private static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.AddPiece(new Tower(Color.black, board), new Position(0, 0));
            board.AddPiece(new Tower(Color.black, board), new Position(1, 3));
            board.AddPiece(new King(Color.black, board), new Position(2, 4));

            Screen.PrintBoard(board);

        }
    }
}