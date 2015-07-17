using System.Collections.Generic;

namespace Pirozgok.Pieces
{
    public class PiceI : IPiece
    {
        public Position GetFit(int[] c)
        {
            var result = new Position();

            result.Rotation = 1;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                //left wall
                if (c.IsLeftWall(i) && cc + 1 < c.Right(i))
                    return result;

                //right wall
                if (c.IsRightWall(i) && cc + 1 < c.Left(i))
                    return result;

                // holl 2 plus deep
                if (c.IsLeft(i) && c.IsRight(i)
                    && c.Left(i) > cc + 1 && cc + 1 < c.Right(i))
                    return result;
            }

            result.Rotation = 0;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRightRightRight(i)) break;

                if (cc != c.Right(i)
                    || cc != c.RightRight(i)
                    || cc != c.RightRightRight(i)) continue;

                //shift it to the right a to give more options for next shape
                if (c.IsRightRightRightRight(i) && cc == c.RightRightRightRight(i))
                    result.X = i + 1;
                return result;
            }

            result.Rotation = 1;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                //left wall
                if (c.IsLeftWall(i) && cc < c.Right(i))
                    return result;

                //right conner
                if (c.IsRightWall(i) && cc < c.Left(i))
                    return result;

                // holl 1 plus deep
                if (c.IsLeft(i) && c.IsRight(i)
                    && c.Left(i) > cc && cc < c.Right(i))
                    return result;
            }

            return result;
        }
    }
}