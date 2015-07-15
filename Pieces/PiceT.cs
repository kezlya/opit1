using System.Runtime.Remoting.Messaging;

namespace Pirozgok.Pieces
{
    public class PiceT : IPiece
    {
        public Position GetFit(int[] c)
        {
            var result = new Position();

            //deep hole 
            result.Rotation = 1;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsLeft(i) || !c.IsRight(i)) continue;

                if (c.Left(i) > cc + 2 && cc + 1 == c.Right(i))
                    return result;
            }

            //deep hole 
            result.Rotation = 3;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRightRight(i)) break;

                if (c.Right(i)+1 == cc && cc + 1 < c.RightRight(i))
                    return result; ;
            }

            result.Rotation = 0;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRightRight(i)) break;

                if (cc == c.Right(i) && cc == c.RightRight(i))
                    return result;
            }

            result.Rotation = 2;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRightRight(i)) break;

                if (cc == c.Right(i) + 1 && cc == c.RightRight(i))
                    return result;
            }

            result.Rotation = 1;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRight(i)) break;

                if (cc + 1 == c.Right(i))
                    return result;
            }

            result.Rotation = 3;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRight(i)) break;

                if (cc == c.Right(i)+1)
                    return result;
            }
            result.Rotation = 0;
            result.X = 0;
            return result;
        }
    }
}