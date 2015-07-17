using System.Collections.Generic;

namespace Pirozgok.Pieces
{
    public interface IPiece
    {
        Position GetFit(int[] columns);
        //TODO: List<Position> GetFits(int[] columns);

       // List<MoveType> GetMoves(Position position);
    }
}