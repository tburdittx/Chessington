using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var position = board.FindPiece(this);
            List<Square> Moves = new List<Square>();

           // if moving diagonally
            {
                for (var i = 0; i < 8; i++)
                    Moves.Add(Square.At(i, i));

                for (var i = 1; i < 8; i++)
                    Moves.Add(Square.At(i, 8 - i));
            }

           // if moving laterally
            {
                for (var i = 0; i < 8; i++)
                    Moves.Add(Square.At(position.Row, i));

                for (var i = 0; i < 8; i++)
                    Moves.Add(Square.At(i, position.Col));
            }

            Moves.RemoveAll(s => s == Square.At(position.Row, position.Col));

            return Moves;


        }
    }
}