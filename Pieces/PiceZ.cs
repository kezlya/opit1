namespace Pirozgok.Pieces
{
    public class PiceZ : IPiece
    {
        public Position GetFit(int[] c)
        {
            var result = new Position();

            result.Rotation = 0;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRightRight(i)) break;

                if (cc != c.Right(i) + 1 || cc != c.RightRight(i) + 1) continue;

                if (c.IsRightRightRight(i) && cc == c.RightRightRight(i) + 1) continue;
                
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

            result.Rotation = 0;
            result.X = 0;
            return result;
        }
    }
}