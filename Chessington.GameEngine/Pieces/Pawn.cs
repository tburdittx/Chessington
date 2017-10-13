using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var position = board.FindPiece(this);
            List<Square> Moves = new List<Square>();
            if (Player==Player.White) 
            {
                Moves.Add(new Square(position.Row - 1, position.Col));                
                if (!PieceHasMoved)
                {
                    Moves.Add(new Square(position.Row - 2, position.Col));
                }
            }

            if (Player==Player.Black)
            {
                Moves.Add(new Square(position.Row + 1, position.Col));
                if (!PieceHasMoved)
                {
                    Moves.Add(new Square(position.Row + 2, position.Col));
                }
            }
            return Moves;
        }
    }
}