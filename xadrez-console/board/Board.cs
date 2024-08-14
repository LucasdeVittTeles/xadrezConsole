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

        public Piece Piece(Position position)
        {
            return _pieces[position.Line, position.Column];
        }

        public bool FreePosition(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }

        public void AddPiece(Piece piece, Position position)
        {
            if (FreePosition(position))
            {
                throw new BoardException("Já existe uma peça nessa posição.");
            }
            _pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public bool ValidPosition(Position postition)
        {
            if (postition.Line < 0 || postition.Line >= Lines || postition.Column < 0 || postition.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Posição inválida!");
            }
        }


    }
}
