namespace Pirozgok.Pieces
{
    public static class PiceS
    {
        public static Position GetFit(int[] c)
        {
            var result = new Position();

            result.Rotation = 0;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRightRight(i)) break;

                if (cc == c.Right(i) && cc + 1 == c.RightRight(i))
                    return result;
            }

            result.Rotation = 1;
            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRight(i)) break;

                if (cc == c.Right(i) + 1)
                    return result;
            }

            result.Rotation = 0;
            result.X = 0;
            return result;
        }
    }
}