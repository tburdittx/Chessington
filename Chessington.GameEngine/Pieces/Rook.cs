using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var position = board.FindPiece(this);  
            
            List<Square> Moves = new List<Square>();

            for (var i = 0; i < 8; i++)
                Moves.Add(Square.At(position.Row, i));

            for (var i = 0; i < 8; i++)
                Moves.Add(Square.At(i, position.Col));

            Moves.RemoveAll(s => s == Square.At(position.Row, position.Col));

            return Moves;           
        }
    }
}