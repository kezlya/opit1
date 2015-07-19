using System.Collections.Generic;

namespace Pirozgok.Pieces
{
    public static class PiceI
    {
        public static List<Position> PositionsDeepHole(int[] c)
        {
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if ((c.IsLeftWall(i) && cc + 1 < c.Right(i))
                    || (c.IsRightWall(i) && cc + 1 < c.Left(i))
                    || (c.IsLeft(i) && c.IsRight(i) && c.Left(i) > cc + 1 && cc + 1 < c.Right(i)))
                    result.Add(new Position
                    {
                        Rotation = 0,
                        X = i,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i, 0, PieceType.I),
                    });
            }
            return result;
        }

        public static List<Position> PositionsFlat(int[] c)
        {
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
                        Rotation = 0,
                        X = i + 1,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i + 1, 0, PieceType.I)
                    });

                    result.Add(new Position
                    {
                        Rotation = 0,
                        X = i,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i, 0, PieceType.I)
                    });

                    i++;
                }
                else
                {
                    result.Add(new Position
                    {
                        Rotation = 0,
                        X = i,
                        BurnRows = 0,
                        ColumsAfter = c.GetColomnsAfter(i, 0, PieceType.I)
                    });
                }
            }
            return result;
        }

        public static List<Position> PositionsOneLevelStep(int[] c)
        {
            var result = new List<Position>();
            for (int i = 0; i < c.Length; i++)
            {
                var cc = c[i];
                if ((c.IsLeftWall(i) && cc < c.Right(i))
                   || (c.IsRightWall(i) && cc < c.Left(i))
                   || (c.IsLeft(i) && c.IsRight(i) && c.Left(i) > cc && cc < c.Right(i)))
                    result.Add(new Position
                     {
                         Rotation = 1,
                         X = i,
                         BurnRows = 0,
                         ColumsAfter = c.GetColomnsAfter(i, 1, PieceType.I),
                     });
            }
            return result;
        }
    }
}