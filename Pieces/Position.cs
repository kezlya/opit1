using System.Linq;

namespace Pirozgok.Pieces
{
    public class Position
    {
        private double _averadge = -1;

        public int Rotation { get; set; }
        public int X { get; set; }
        public int [] ColumsAfter { get; set; }
        public int BurnRows { get; set; }
        public PieceType Type { get; set; }

        public double ColumsAfterAve
        {
            get
            {
                if (_averadge < 0)
                    _averadge = ColumsAfter.Average();
                return _averadge;
            }
        }
    }
}