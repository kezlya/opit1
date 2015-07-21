using System.Collections.Generic;

namespace Pirozgok.Pieces
{
    public static class PiceO
    {
        public static List<Position> PositionsDeepHole(int[] c)
        {
            const int rotation = 0;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if ((c.IsLeft(i) && c.Left(i) > cc + 1 && c.IsRight(i) && cc == c.Right(i))
                   || (c.IsRightRight(i) && cc == c.Right(i) && cc + 1 < c.RightRight(i)))
                    result.Add(new Position
                    {
                        Type = PieceType.O,
                        Rotation = rotation,
                        X = i,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.O),
                    });
            }
            return result;
        }

        public static List<Position> PositionsOneLevelStep(int[] c)
        {
            const int rotation = 0;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if ((c.IsLeft(i) && c.Left(i) > cc && c.IsRight(i) && cc == c.Right(i))
                   || (c.IsRightRight(i) && cc == c.Right(i) && cc < c.RightRight(i)))
                    result.Add(new Position
                    {
                        Type = PieceType.O,
                        Rotation = rotation,
                        X = i,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.O),
                    });
            }
            return result;
        }

        public static List<Position> PositionsFlat(int[] c)
        {
            const int rotation = 0;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if (!c.IsRight(i)) break;
                if (cc != c.Right(i)) continue;

                result.Add(new Position
                {
                    Type = PieceType.O,
                    Rotation = rotation,
                    X = i,
                    BurnRows = 0,
                    ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.O),
                });
            }
            return result;
        }
    }
}