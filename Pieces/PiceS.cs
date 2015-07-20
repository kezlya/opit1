using System.Collections.Generic;

namespace Pirozgok.Pieces
{
    public static class PiceS
    {
        public static List<Position> PositionsFlat(int[] c)
        {
            const int rotation = 0;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if (!c.IsRightRight(i)) break;
                if (cc != c.Right(i) || cc + 1 != c.RightRight(i)) continue;

                result.Add(new Position
                {
                    Rotation = rotation,
                    X = i,
                    BurnRows = 0,
                    ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.S),
                });
            }
            return result;
        }
        public static List<Position> PositionsVerticle(int[] c)
        {
            const int rotation = 1;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if (!c.IsRight(i)) break;
                if (cc != c.Right(i) + 1) continue;

                result.Add(new Position
                {
                    Rotation = rotation,
                    X = i,
                    BurnRows = 0,
                    ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.S),
                });
            }
            return result;
        }
    }
}