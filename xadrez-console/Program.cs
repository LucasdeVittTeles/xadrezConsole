using board;
using chess;

namespace xadrez_console
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                ChessMatch chessMatch = new ChessMatch();

                while (!chessMatch.Finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(chessMatch.Board);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Position origin = Screen.ReadPositionChess().ToPosition();
                    Console.Write("Destino: ");
                    Position destination = Screen.ReadPositionChess().ToPosition();

                    chessMatch.PerformMoves(origin, destination);
                }
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}