namespace Pirozgok.Pieces
{
    public static class PiceJ
    {
        public static Position GetFit(int[] c)
        {
            var result = new Position();

            result.Rotation = 1;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (c.IsRight(i) && cc + 2 == c.Right(i))
                    return result;
            }

            result.Rotation = 2;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i]; 
                
                if (c.IsRightRight(i) && cc == c.Right(i) && cc == c.RightRight(i) + 1)
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

            result.Rotation = 3;
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