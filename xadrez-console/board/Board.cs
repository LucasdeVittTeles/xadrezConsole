namespace board
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }

        private Piece[,] _pieces;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            _pieces = new Piece[lines, columns];
        }

        public Piece Piece(int line, int column)
        {
            return _pieces[line, column];
        }

        public void AddPiece(Piece piece, Position position)
        {
            _pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }


    }
}
