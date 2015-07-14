namespace Pirozgok.Pieces
{
    public interface IPiece
    {
        Position GetFit(int[] columns);
        //TODO: List<Position> GetFits(int[] columns);
    }
}