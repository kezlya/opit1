using System.Collections.Generic;

namespace Pirozgok.Pieces
{
    public static class PiceL
    {
        public static List<Position> PositionsDeepHole(int[] c)
        {
            const int rotation = 3;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if (c.IsRight(i) && cc == c.Right(i) + 2)
                    result.Add(new Position
                    {
                        Type = PieceType.L,
                        Rotation = rotation,
                        X = i,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.L),
                    });
            }
            return result;
        }

        public static List<Position> PositionsFlatHole(int[] c)
        {
            const int rotation = 2;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if (c.IsRightRight(i) && cc + 1 == c.Right(i) && cc + 1 == c.RightRight(i))
                    result.Add(new Position
                    {
                        Type = PieceType.L,
                        Rotation = rotation,
                        X = i,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.L),
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
                if (!c.IsRightRight(i)) break;
                if (cc != c.Right(i) || cc != c.RightRight(i)) continue;

                result.Add(new Position
                {
                    Type = PieceType.L,
                    Rotation = rotation,
                    X = i,
                    BurnRows = 0,
                    ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.L),
                });
            }
            return result;
        }
        public static List<Position> PositionsNotFlat(int[] c)
        {
            const int rotation = 1;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if (!c.IsRight(i)) break;
                if (cc != c.Right(i)) continue;

                result.Add(new Position
                {
                    Type = PieceType.L,
                    Rotation = rotation,
                    X = i,
                    BurnRows = 0,
                    ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.L),
                });
            }
            return result;
        }
    }
}