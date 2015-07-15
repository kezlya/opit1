namespace Pirozgok.Pieces
{
    public class PiceL : IPiece
    {
        public Position GetFit(int[] c)
        {
            var result = new Position();

            result.Rotation = 3;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (c.IsRight(i) && cc == c.Right(i) + 2)
                    return result;
            }

            result.Rotation = 2;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (c.IsRightRight(i) && cc + 1 == c.Right(i) && cc + 1 == c.RightRight(i))
                    return result;
            }

            result.Rotation = 0;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRightRight(i)) break;

                if (cc != c.Right(i) || cc != c.RightRight(i)) continue;

                return result;
            }

            result.Rotation = 1;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRight(i)) break;

                if (cc != c.Right(i)) continue;

                return result;
            }

            result.Rotation = 0;
            result.X = 0;
            return result;
        }
    }
}