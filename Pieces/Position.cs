namespace Pirozgok.Pieces
{
    public class Position
    {

        public int Rotation { get; set; }
        public int X { get; set; }
        public int [] ColumsAfter { get; set; }
        public int BurnRows { get; set; }
        public PieceType Type { get; set; }
    }
}