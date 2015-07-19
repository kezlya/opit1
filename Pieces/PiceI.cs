using System.Collections.Generic;

namespace Pirozgok.Pieces
{
    public static class PiceI
    {
        public static List<Position> PositionsDeepHole(int[] c)
        {
            const int rotation = 1;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if ((c.IsRight(i) && cc + 1 < c.Right(i))
                    || (c.IsLeft(i) && cc + 1 < c.Left(i)))
                    result.Add(new Position
                    {
                        Rotation = rotation,
                        X = i,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.I),
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

                if (!c.IsRightRightRight(i)) break;

                if (cc != c.Right(i)
                    || cc != c.RightRight(i)
                    || cc != c.RightRightRight(i)) continue;


                //shift it to the right a to give more options for next shape
                if (c.IsRightRightRightRight(i) && cc == c.RightRightRightRight(i))
                {
                    result.Add(new Position
                    {
                        Rotation = rotation,
                        X = i + 1,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i + 1, rotation, PieceType.I)
                    });

                    result.Add(new Position
                    {
                        Rotation = rotation,
                        X = i,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.I)
                    });

                    i++;
                }
                else
                {
                    result.Add(new Position
                    {
                        Rotation = rotation,
                        X = i,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.I)
                    });
                }
            }
            return result;
        }

        public static List<Position> PositionsOneLevelStep(int[] c)
        {
            const int rotation = 1;
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if ((c.IsLeft(i) && c.Left(i) > cc)
                   || (c.IsRight(i) && cc < c.Right(i)))
                    result.Add(new Position
                     {
                         Rotation = rotation,
                         X = i,
                         BurnRows = 0,
                         ColumsAfter = c.GetColomnsAfter(i, rotation, PieceType.I),
                     });
            }
            return result;
        }
    }
}