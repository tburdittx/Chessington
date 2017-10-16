using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var position = board.FindPiece(this);
            List<Square> Moves = new List<Square>();

            Moves.Add(Square.At(position.Row - 1, position.Col + 2));
            Moves.Add(Square.At(position.Row - 2, position.Col + 1));
            Moves.Add(Square.At(position.Row - 1, position.Col - 2));
            Moves.Add(Square.At(position.Row - 2, position.Col - 1));
            Moves.Add(Square.At(position.Row + 2, position.Col + 1));
            Moves.Add(Square.At(position.Row + 1, position.Col + 2));
            Moves.Add(Square.At(position.Row + 2, position.Col - 1));
            Moves.Add(Square.At(position.Row + 1, position.Col - 2));

            Moves.RemoveAll(s => s == Square.At(position.Row, position.Col));
            Moves.RemoveAll(s => s.Row < 0);
            Moves.RemoveAll(s => s.Col > 7);
            
            //foreach (var square in Moves)
            //{
            //    if (square.Row  < 0 |square.Row>7)
            //    {
            //        Moves.RemoveAt(position.Row);
            //    }
                
            //}
            //foreach (var square in Moves)
            //{
            //    if (square.Col > 7|square.Col<0)
            //    {
            //        Moves.RemoveAt(position.Col);
            //    }
            //}



            Console.WriteLine(Square.At(position.Row, position.Col));

            return Moves;
        }
    }
}