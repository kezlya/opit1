using System.Collections.Generic;

namespace Pirozgok.Pieces
{
    public static class PiceT
    {
        public static List<Position> PositionsPointDown(int[] c)
        {
            const int rotation = 2;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if (!c.IsRightRight(i)) break;
                if (cc != c.Right(i) + 1 || cc != c.RightRight(i)) continue;

                result.Add(new Position
                {
                    Rotation = rotation,
                    X = i,
                    BurnRows = 0,
                    ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.T),
                });
            }
            return result;
        }

        public static List<Position> PositionsPointUp(int[] c)
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
                    Rotation = rotation,
                    X = i,
                    BurnRows = 0,
                    ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.T),
                });
            }
            return result;
        }

        public static List<Position> PositionsPointRight(int[] c)
        {
            const int rotation = 1;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if (!c.IsRight(i)) break;
                if (cc + 1 != c.Right(i)) continue;

                result.Add(new Position
                {
                    Rotation = rotation,
                    X = i,
                    BurnRows = 0,
                    ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.T),
                });
            }
            return result;
        }

        public static List<Position> PositionsPointLeft(int[] c)
        {
            const int rotation = 3;
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
                    ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.T),
                });
            }
            return result;
        }
    }
}