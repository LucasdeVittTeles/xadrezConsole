using board;

namespace chess
{
    class ChessMatch
    {
        public Board Board { get; private set; }
        private int _turn;
        private Color _currentPlayer;
        public bool Finished { get; private set; }

        public ChessMatch()
        {
            Board = new Board(8, 8);
            _turn = 1;
            _currentPlayer = Color.white;
            Finished = false;
            PlacePieces();
        }

        public void PerformMoves(Position origin, Position destination)
        {
            Piece piece = Board.RemovePiece(origin);
            piece.AddNumberMoves();
            Piece caughtPiece = Board.RemovePiece(destination);
            Board.AddPiece(piece, destination);
        }

        private void PlacePieces()
        {
            Board.AddPiece(new Tower(Color.white, Board), new PositionChess('c', 1).ToPosition());
            Board.AddPiece(new Tower(Color.white, Board), new PositionChess('c', 2).ToPosition());
            Board.AddPiece(new Tower(Color.white, Board), new PositionChess('d', 2).ToPosition());
            Board.AddPiece(new Tower(Color.white, Board), new PositionChess('e', 2).ToPosition());
            Board.AddPiece(new Tower(Color.white, Board), new PositionChess('e', 1).ToPosition());
            Board.AddPiece(new King(Color.white, Board), new PositionChess('d', 1).ToPosition());

            Board.AddPiece(new Tower(Color.black, Board), new PositionChess('c', 7).ToPosition());
            Board.AddPiece(new Tower(Color.black, Board), new PositionChess('c', 8).ToPosition());
            Board.AddPiece(new Tower(Color.black, Board), new PositionChess('d', 7).ToPosition());
            Board.AddPiece(new Tower(Color.black, Board), new PositionChess('e', 7).ToPosition());
            Board.AddPiece(new Tower(Color.black, Board), new PositionChess('e', 8).ToPosition());
            Board.AddPiece(new King(Color.black, Board), new PositionChess('d', 8).ToPosition());

        }

    }
}
